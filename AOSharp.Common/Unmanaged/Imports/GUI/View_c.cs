﻿using System;
using System.Text;
using System.Runtime.InteropServices;
using AOSharp.Common.Unmanaged.DataTypes;
using AOSharp.Common.GameData;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class View_c
    {
        [DllImport("GUI.dll", EntryPoint = "??0View@@QAE@ABVRect@@ABVString@@II@Z", CallingConvention = CallingConvention.ThisCall)]
        internal static extern unsafe IntPtr Constructor(IntPtr pThis, Rect* rect, IntPtr pName, int unk1, int unk2);

        [DllImport("GUI.dll", EntryPoint = "??1View@@UAE@XZ", CallingConvention = CallingConvention.ThisCall)]
        public static extern int Deconstructor(IntPtr pThis);

        [DllImport("GUI.dll", EntryPoint = "?AddChild@View@@UAEXPAV1@_N@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern void AddChild(IntPtr pThis, IntPtr pView, bool unk);

        [DllImport("GUI.dll", EntryPoint = "?SetBorders@View@@QAEXMMMM@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern void SetBorders(IntPtr pThis, float minX, float minY, float maxX, float maxY);

        [DllImport("GUI.dll", EntryPoint = "?LimitMaxSize@View@@QAEXABVPoint@@@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern unsafe void LimitMaxSize(IntPtr pThis, Vector2* maxSize);

        [DllImport("GUI.dll", EntryPoint = "?SetFrame@View@@UAEXABVRect@@_N@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern unsafe void SetFrame(IntPtr pThis, Rect* rect, bool unk);

        [DllImport("GUI.dll", EntryPoint = "?Show@View@@QAEX_N0@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern void Show(IntPtr pThis, bool visible, bool unk);

        [DllImport("GUI.dll", EntryPoint = "?SetLayoutNode@View@@QAEXPAVLayoutNode@@@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern void SetLayoutNode(IntPtr pThis, IntPtr pLayoutNode);


        public static unsafe IntPtr Create(Rect rect, string name, int unk1, int unk2)
        {
            StdString nameStr = StdString.Create(name);
            IntPtr pView = Constructor(MSVCR100.New(0x128), &rect, nameStr.Pointer, unk1, unk2);

            return pView;
        }
    }
}
