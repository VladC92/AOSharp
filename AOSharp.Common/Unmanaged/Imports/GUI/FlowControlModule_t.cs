﻿using System;
using System.Runtime.InteropServices;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class FlowControlModule_t
    {
        [DllImport("GUI.dll", EntryPoint = "?TeleportStartedMessage@FlowControlModule_t@@CAXXZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TeleportStartedMessage ();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode, SetLastError = true)]
        public delegate void DTeleportStartedMessage();

        public static unsafe bool* pIsTeleporting = (bool*)Kernel32.GetProcAddress(Kernel32.GetModuleHandle("GUI.dll"), "?m_isTeleporting@FlowControlModule_t@@2_NA");
    }
}
