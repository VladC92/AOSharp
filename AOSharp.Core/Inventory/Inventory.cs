﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOSharp.Common.GameData;
using AOSharp.Common.Unmanaged.Imports;
using AOSharp.Common.Unmanaged.DataTypes;

namespace AOSharp.Core.Inventory
{
    public static class Inventory
    {
        public static List<Item> Items => GetItems(DynelManager.LocalPlayer.Identity);

        public static List<Container> Backpacks => Items.Where(x => x.UniqueIdentity.Type == IdentityType.Container).Select(x => new Container(x.UniqueIdentity, x.Slot)).ToList();

        public static bool Find(Identity slot, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.Slot == slot)) != null;
        }

        public static bool Find(int id, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.LowId == id || x.HighId == id)) != null;
        }

        public static bool Find(int lowId, int highId, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.LowId == lowId && x.HighId == highId)) != null;
        }

        public static List<Item> FindAll(int id)
        {
            return Items.Where(x => x.LowId == id || x.HighId == id).ToList();
        }

        public static List<Item> FindAll(int lowId, int highId)
        {
            return Items.Where(x => x.LowId == lowId && x.HighId == highId).ToList();
        }

        //This will likely be made internal once I provide a way of accessing the inventory of all types of containers.
        //For now just utilize this if you REALLY need the contents of something random like contracts (and i guess bank too)
        public static unsafe List<Item> GetItems(Identity container)
        {
            List<Item> items = new List<Item>();
            IntPtr pEngine = N3Engine_t.GetInstance();

            if (pEngine == IntPtr.Zero)
                return items;

            IntPtr pItems = N3EngineClientAnarchy_t.GetInventoryVec(pEngine, ref container);

            if (pItems == IntPtr.Zero)
                return items;

            int i = 0;
            foreach (IntPtr pItem in (*(StdStructVector*)pItems).ToList(sizeof(IntPtr)))
            {
                //Resolve proper type for item slot
                IdentityType slotType = IdentityType.None;

                switch (container.Type)
                {
                    case IdentityType.SimpleChar:
                        slotType = IdentityType.Inventory;

                        //Correct the slot type to match the equipment pages
                        if (i <= (int)EquipSlot.Weap_Deck6)
                            slotType = IdentityType.WeaponPage;
                        else if (i <= (int)EquipSlot.Cloth_LeftFinger)
                            slotType = IdentityType.ArmorPage;
                        else if (i <= (int)EquipSlot.Imp_Feet)
                            slotType = IdentityType.ImplantPage;
                        else if (i <= (int)EquipSlot.Social_LeftWeap)
                            slotType = IdentityType.SocialPage;

                        break;
                    case IdentityType.Bank:
                        slotType = IdentityType.BankByRef;
                        break;
                }

                IntPtr pActualItem = *(IntPtr*)pItem;

                if (pActualItem != IntPtr.Zero)
                {
                    try {
                    int lowId = (*(ItemMemStruct*)pActualItem).LowId;
                    int highId = (*(ItemMemStruct*)pActualItem).HighId;
                    int ql = (*(ItemMemStruct*)pActualItem).QualityLevel;
                    Identity unqiueIdentity = (*(ItemMemStruct*)pActualItem).UniqueIdentity;
                    items.Add(new Item(lowId, highId, ql, unqiueIdentity, new Identity(slotType, i)));
                    } catch { }
                }

                i++;
            }

            return items;
        }

        public static unsafe List<Item> GetContainerItems(Identity identity)
        {
            List<Item> items = new List<Item>();

            IntPtr pEngine = N3Engine_t.GetInstance();

            if (pEngine == IntPtr.Zero)
                return items;

            IntPtr pInvList = N3EngineClientAnarchy_t.GetContainerInventoryList(pEngine, &identity);

            if (pInvList == IntPtr.Zero)
                return items;

            IntPtr pItems = N3EngineClientAnarchy_t.GetInventoryVec(pEngine, ref identity);

            if (pItems == IntPtr.Zero)
                return items;

            List<IntPtr> containerInvList = (*(StdObjList*)pInvList).ToList();

            int i = 0;
            foreach (IntPtr pItem in (*(StdStructVector*)pItems).ToList(sizeof(IntPtr)))
            {
                IntPtr pActualItem = *(IntPtr*)pItem;

                if (pActualItem != IntPtr.Zero)
                {
                    try
                    {
                        int lowId = (*(ItemMemStruct*)pActualItem).LowId;
                        int highId = (*(ItemMemStruct*)pActualItem).HighId;
                        int ql = (*(ItemMemStruct*)pActualItem).QualityLevel;
                        Identity unqiueIdentity = (*(ItemMemStruct*)pActualItem).UniqueIdentity;
                        Identity slot = *((Identity*)(containerInvList[i] + 0x8));
                        items.Add(new Item(lowId, highId, ql, unqiueIdentity, slot));
                    } catch {}
                    i++;
                }
            }
            return items;
        }

        [StructLayout(LayoutKind.Explicit, Pack = 0)]
        private struct ItemMemStruct
        {
            [FieldOffset(0x0)]
            public int Unk1; //Flags?

            [FieldOffset(0x04)]
            public Identity UniqueIdentity;

            [FieldOffset(0x0C)]
            public int LowId;

            [FieldOffset(0x10)]
            public int HighId;

            [FieldOffset(0x14)]
            public int QualityLevel;

            [FieldOffset(0x18)]
            public int Quantity;

            [FieldOffset(0x24)]
            public int Unk2; //Some other flags?
        }
    }
}
