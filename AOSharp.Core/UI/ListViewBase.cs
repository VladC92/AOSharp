﻿using System;
using AOSharp.Common.GameData;
using AOSharp.Common.Unmanaged.Imports;
namespace AOSharp.Core.UI
{
    public class ListViewBase : View
    {
        internal ListViewBase(IntPtr pointer, bool register) : base(pointer, register)
        {
        }

        public static ListViewBase FromPointer(IntPtr pointer, bool register)
        {
            return new ListViewBase(pointer, register);
        }

        public static ListViewBase Create(Rect rect, string name)
        {
            IntPtr pView = ListViewBase_c.Create(rect, name, -1, 0, 0);

            if (pView == IntPtr.Zero)
                return null;

            return new ListViewBase(pView, true);
        }

        public override void Dispose()
        {
            ListViewBase_c.Deconstructor(_pointer);
        }

        public void AppendItem(StringListViewItem item)
        {
            ListViewBase_c.AppendItem(_pointer, item.Pointer);
        }
    }
}
