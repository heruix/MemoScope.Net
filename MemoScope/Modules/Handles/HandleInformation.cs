﻿using BrightIdeasSoftware;
using MemoScope.Core;
using Microsoft.Diagnostics.Runtime;
using System.Windows.Forms;

namespace MemoScope.Modules.Handles
{
    public class HandleInformation
    {
        private ClrHandle clrHandle;

        public HandleInformation(ClrDump clrDump, ClrHandle clrHandle)
        {
            this.clrHandle = clrHandle;
        }

        [OLVColumn]
        public ulong Object => clrHandle.Object;
        [OLVColumn]
        public string Type => clrHandle.Type.Name;
        [OLVColumn]
        public HandleType HandleType => clrHandle.HandleType;
        [OLVColumn(Width = 50, TextAlign = HorizontalAlignment.Center)]
        public bool IsPinned => clrHandle.IsPinned;
        [OLVColumn(Width = 50, TextAlign = HorizontalAlignment.Center)]
        public bool IsStrong => clrHandle.IsStrong;
        [OLVColumn(Width = 50, TextAlign = HorizontalAlignment.Right, AspectToStringFormat = "{0:###,###,###,##0}")]
        public uint RefCount => clrHandle.RefCount;
    }
}