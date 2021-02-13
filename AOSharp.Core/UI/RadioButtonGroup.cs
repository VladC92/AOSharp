﻿using System;
using AOSharp.Core.GameData;
using AOSharp.Common.Unmanaged.Imports;
using AOSharp.Common.Unmanaged.DataTypes;

namespace AOSharp.Core.UI
{
    public class RadioButtonGroup : View
    {
        internal RadioButtonGroup(IntPtr pointer) : base(pointer)
        {
        }

        public static RadioButtonGroup Create(string name)
        {
            IntPtr pView = RadioButtonGroup_c.Create(name, -1, 0, 0);
            if (pView == IntPtr.Zero)
                return null;

            return new RadioButtonGroup(pView);
        }

        public override void Dispose()
        {
            View_c.Deconstructor(_pointer);
        }

        public override void Update()
        {
        }
    }
}
