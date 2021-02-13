﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOSharp.Common.GameData;
using AOSharp.Common.Unmanaged.DataTypes;
using AOSharp.Common.Unmanaged.Imports;

namespace AOSharp.Core
{
    public static unsafe class Playfield
    {
        ///<summary>
        ///Playfield Identity
        ///</summary>
        public static Identity Identity => GetIdentity();

        ///<summary>
        ///Playfield's model identity
        ///</summary>
        public static Identity ModelIdentity => GetModelIdentity();

        ///<summary>
        ///Are mechs allowed on the playfield
        ///</summary>
        public static bool AllowsVehicles => AreVehiclesAllowed();

        ///<summary>
        ///Is Shadowlands playfield
        ///</summary>
        public static bool IsShadowlands => IsShadowlandPF();

        ///<summary>
        ///Is BattleStation
        ///</summary>
        public static bool IsBattleStation => IsBattleStationPF();

        ///<summary>
        ///Is playfield a dungeon
        ///</summary>
        public static bool IsDungeon => IsDungeonPF();

        ///<summary>
        ///Playfield name
        ///</summary>
        public static string Name => GetName();

        ///<summary>
        ///Get zones (cells) for playfield.
        ///</summary>
        public static List<Zone> Zones => GetZones();

        ///<summary>
        ///Get rooms for playfield if in a dungeon.
        ///</summary>
        public static List<Room> Rooms => GetRooms();

        //TODO: Convert to use n3Playfield_t::GetPlayfieldDynels() to remove dependencies on hard-coded offsets
        internal static unsafe List<IntPtr> GetPlayfieldDynels()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return new List<IntPtr>();

            return (*(Playfield_MemStruct*)pPlayfield).Dynels.ToList();
        }

        private static unsafe Identity GetIdentity()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return Identity.None;

            return *N3Playfield_t.GetIdentity(pPlayfield);
        }

        private static unsafe Identity GetModelIdentity()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return Identity.None;

            return *N3Playfield_t.GetModelID(pPlayfield);
        }

        private static string GetName()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return String.Empty;

            return Marshal.PtrToStringAnsi(N3Playfield_t.GetName(pPlayfield));
        }

        private static unsafe List<Zone> GetZones()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return new List<Zone>();

            return (*N3Playfield_t.GetZones(pPlayfield)).ToList().Select(x => new Zone(x)).ToList();
        }

        private static unsafe List<Room> GetRooms()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero || !IsDungeon)
                return new List<Room>();

            return (*N3Playfield_t.GetZones(pPlayfield)).ToList().Select(x => new Room(x)).ToList();
        }

        private static bool AreVehiclesAllowed()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return false;

            return PlayfieldAnarchy_t.AreVehiclesAllowed(pPlayfield);
        }

        private static bool IsShadowlandPF()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return false;

            return PlayfieldAnarchy_t.IsShadowlandPF(pPlayfield);
        }
        public static bool Raycast(Vector3 pos1, Vector3 pos2, out Vector3 hitPos, out Vector3 hitNormal)
        {
            hitPos = Vector3.Zero;
            hitNormal = Vector3.Zero;

            IntPtr pSurface = GetSurface();

            if (pSurface == IntPtr.Zero)
                return false;

            return TilemapSurface_t.GetLineIntersection(pSurface, ref pos1, ref pos2, ref hitPos, ref hitNormal, 1, IntPtr.Zero);
        }

        public static bool LineOfSight(Vector3 pos1, Vector3 pos2, int zoneCell = 1, bool unknown = false)
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return false;

            return N3Playfield_t.LineOfSight(pPlayfield, &pos1, &pos2, zoneCell, false);
        }

        private static bool IsDungeonPF()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return false;

            return N3Playfield_t.IsDungeon(pPlayfield);
        }

        private static bool IsBattleStationPF()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return false;

            return N3Playfield_t.IsBattleStation(pPlayfield);
        }

        internal static IntPtr GetSurface()
        {
            IntPtr pPlayfield = N3EngineClient_t.GetPlayfield();

            if (pPlayfield == IntPtr.Zero)
                return IntPtr.Zero;

            return N3Playfield_t.GetSurface(pPlayfield);
        }

        [StructLayout(LayoutKind.Explicit, Pack = 0)]
        private struct Playfield_MemStruct
        {
            [FieldOffset(0x30)]
            public StdObjVector Dynels;
        }
    }
}
