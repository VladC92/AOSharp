﻿using AOSharp.Common.GameData;
using AOSharp.Core.GameData;
using AOSharp.Common.Unmanaged.Imports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AOSharp.Core.Inventory
{
    public abstract class ItemHolder
    {
        public abstract List<Item> Items { get; }

        public bool Find(Identity slot, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.Slot == slot)) != null;
        }

        public bool Find(int id, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.LowId == id || x.HighId == id)) != null;
        }

        public bool Find(int lowId, int highId, out Item item)
        {
            return (item = Items.FirstOrDefault(x => x.LowId == lowId && x.HighId == highId)) != null;
        }

        public List<Item> FindAll(int id)
        {
            return Items.Where(x => x.LowId == id || x.HighId == id).ToList();
        }

        public List<Item> FindAll(int lowId, int highId)
        {
            return Items.Where(x => x.LowId == lowId && x.HighId == highId).ToList();
        }
    }
}
