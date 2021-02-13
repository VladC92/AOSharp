﻿using System;
using System.Runtime.InteropServices;
using AOSharp.Common.GameData;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class TeamViewModule_c
    {
        [DllImport("GUI.dll", EntryPoint = "?GetInstanceIfAny@TeamViewModule_c@@SAPAV1@XZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetInstanceIfAny();

        [DllImport("GUI.dll", EntryPoint = "?IsTeamLeader@TeamViewModule_c@@QBE_NXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern byte IsTeamLeader(IntPtr pThis);

        [DllImport("GUI.dll", EntryPoint = "?IsInTeam@TeamViewModule_c@@QBE_NXZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern byte IsInTeam(IntPtr pThis);

        [DllImport("GUI.dll", EntryPoint = "?SlotJoinTeamRequest@TeamViewModule_c@@AAEXABVIdentity_t@@ABV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern unsafe void SlotJoinTeamRequest(IntPtr pThis, Identity* identity, IntPtr pName);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public unsafe delegate void DSlotJoinTeamRequest(IntPtr pThis, IntPtr identity, IntPtr pName);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public unsafe delegate void DSlotJoinTeamRequestFailed(IntPtr pThis, ref Identity identity);
    }
}
