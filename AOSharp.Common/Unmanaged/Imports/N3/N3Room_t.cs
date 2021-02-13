﻿using System;
using System.Runtime.InteropServices;
using AOSharp.Common.GameData;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class N3Room_t
    {
        [DllImport("N3.dll", EntryPoint = "?GetRoomRect@n3Room_t@@QBEXAAM000@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern void GetRoomRect(IntPtr pThis, out float x, out float x2, out float y, out float y2);

        [DllImport("N3.dll", EntryPoint = "?GetCenter@n3Room_t@@QBEABVVector3_t@@XZ", CallingConvention = CallingConvention.ThisCall)]
        public static unsafe extern Vector3* GetCenter(IntPtr pThis);

        [DllImport("N3.dll", EntryPoint = "?GetPos@n3Room_t@@QBEABVVector3_t@@XZ", CallingConvention = CallingConvention.ThisCall)]
        public static unsafe extern Vector3* GetPos(IntPtr pThis);

        [DllImport("N3.dll", EntryPoint = "?GetRot@n3Room_t@@QBEHXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern int GetRot(IntPtr pThis);

        [DllImport("N3.dll", EntryPoint = "?GetName@n3Room_t@@QBEPBDXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr GetName(IntPtr pThis);

        [DllImport("N3.dll", EntryPoint = "?GetFloor@n3Room_t@@QBEHXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern int GetFloor(IntPtr pThis);

        [DllImport("N3.dll", EntryPoint = "?GetNumDoors@n3Room_t@@QBEHXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern int GetNumDoors(IntPtr pThis);
    }
}
