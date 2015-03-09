﻿using System.Drawing;
using MW5.Plugins.Concrete;
using MW5.UI;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace MW5.Helpers
{
    internal static class CommandBarHelper
    {
        public static void DockToolbar(this MainFrameBarManager manager, Bar bar, CommandBarDockState dockState)
        {
            var cbr = manager.GetBarControl(bar) as CommandBarExt;
            if (cbr != null)
            {
                cbr.DockState = dockState;
            }
        }

        public static void FloatToolbar(this MainFrameBarManager manager, Bar bar, System.Drawing.Point location)
        {
            var cbr = manager.GetBarControl(bar) as CommandBarExt;
            if (cbr != null)
            {
                cbr.DockState = CommandBarDockState.Float;
                var form = cbr.Parent as CommandBarForm;
                if (form != null)
                {
                    form.Location = location;
                }
            }
        }

        public static void InitMenuColors()
        {
            MenuColors.CommandBarBackColor = Color.White;
            MenuColors.MainMenuBackColor = Color.White;
            MenuColors.StatusBarBackColor = Color.White;
        }
    }
}
