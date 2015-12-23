﻿using WinFwk.UIModules;

namespace MemoScope.Modules.InstanceDetails
{
    public partial class InstanceDetailsModule : UIModule
    {
        private ClrDumpObject ClrDumpObject { get; set; }
        public InstanceDetailsModule()
        {
            InitializeComponent();
        }

        internal void Setup(ClrDumpObject clrDumpObject)
        {
            ClrDumpObject = clrDumpObject;
            tbAddress.Text = clrDumpObject.Address.ToString("X");
        }

        public override void PostInit()
        {
            Name = "#" + ClrDumpObject.Dump.Id + " - " + ClrDumpObject.Address.ToString("X");
            Summary = ClrDumpObject.Type.Name;
        }
    }


}