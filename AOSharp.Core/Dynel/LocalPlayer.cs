﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOSharp.Common.GameData;
using AOSharp.Core.GameData;
using AOSharp.Common.Unmanaged.DataTypes;
using AOSharp.Common.Unmanaged.Imports;

namespace AOSharp.Core
{
    public unsafe class LocalPlayer : SimpleChar
    {
        private const float AttackAttemptDelay = 0.5f;

        public Dictionary<Stat, Cooldown> Cooldowns => GetCooldowns();

        internal List<Mission> MissionList => GetMissionList();

        public float AttackRange => GetAttackRange();

        public int CurrentNCU => GetStat(Stat.CurrentNCU);

        public int MaxNCU => GetStat(Stat.MaxNCU);

        public int RemainingNCU => MaxNCU - CurrentNCU;

        public Pet[] Pets => GetPets();

        public bool IsAttackPending => Time.NormalTime < _nextAttack;

        private static double _nextAttack;

        internal IntPtr NanoControllerPointer => (*(MemStruct*)Pointer).NanoController;

        public LocalPlayer(IntPtr pointer) : base(pointer)
        {
        }

        public void Attack(Dynel target, bool attackWithPets = true)
        {
            if (target.GetStat(Stat.Health) == 0)
                return;

            Attack(target.Identity);

            if (attackWithPets && Pets.Length > 0)
                Pets.Attack(target.Identity);
        }

        public void Attack(Identity target)
        {
            IntPtr pEngine = N3Engine_t.GetInstance();

            if (pEngine == IntPtr.Zero)
                return;

            N3EngineClientAnarchy_t.DefaultAttack(pEngine, &target, true);

            _nextAttack = Time.NormalTime + AttackAttemptDelay;
        }

        public void StopAttack()
        {
            IntPtr pEngine = N3Engine_t.GetInstance();

            if (pEngine == IntPtr.Zero)
                return;

            N3EngineClientAnarchy_t.StopAttack(pEngine);

            if (Pets.Length > 0)
                Pets.Follow();
        }

        public float GetAttackRange()
        {
            IntPtr pEngine = N3Engine_t.GetInstance();

            if (pEngine == IntPtr.Zero)
                return 0f;

            return N3EngineClientAnarchy_t.GetAttackRange(pEngine);
        }

        private Dictionary<Stat, Cooldown> GetCooldowns()
        {
            Dictionary<Stat, Cooldown> cooldowns = new Dictionary<Stat, Cooldown>();

            IntPtr pUnk = *(*(MemStruct*)Pointer).CooldownUnk;

            if (pUnk == IntPtr.Zero)
                return cooldowns;

            StdStructVector cooldownVector = *(StdStructVector*)pUnk;

            foreach(IntPtr pCooldown in cooldownVector.ToList(sizeof(Cooldown)))
            {
                Cooldown cooldown = *(Cooldown*)pCooldown;
                cooldowns.Add(cooldown.Stat, cooldown);
            }

            return cooldowns;
        }

        internal List<Mission> GetMissionList()
        {
            List<Mission> missions = new List<Mission>();

            IntPtr pUnk = (*(MemStruct*)Pointer).MissionUnk;

            if (pUnk == IntPtr.Zero)
                return missions;

            StdObjVector* missionVector = (StdObjVector*)(pUnk + 0x04);


            foreach (IntPtr pMission in missionVector->ToList())
            {
                Mission mission = new Mission(pMission);
                missions.Add(mission);
            }

            return missions;
        }

        private Pet[] GetPets()
        {
            List<Pet> pets = new List<Pet>();
            IntPtr pPetWindowModule = PetWindowModule_c.GetInstance();

            if (pPetWindowModule == IntPtr.Zero)
                return pets.ToArray();

            for (byte i = 1; i < 6; i++)
            {
                Identity pet = Identity.None;
                PetWindowModule_c.GetPetID(pPetWindowModule, ref pet, i);

                if (pet == Identity.None)
                    continue;

                pets.Add(new Pet(pet));
            }

            return pets.ToArray();
        }

        [StructLayout(LayoutKind.Explicit, Pack = 0)]
        private new struct MemStruct
        {
            [FieldOffset(0x1BC)]
            public IntPtr* CooldownUnk;

            [FieldOffset(0x1C0)]
            public IntPtr NanoController;

            [FieldOffset(0x1C4)]
            public IntPtr MissionUnk;

            [FieldOffset(0x1D8)]
            public NpcHolder* NpcHolder;
        }
    }
}
