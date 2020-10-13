using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Testing.WinFormsWithXamlIslands
{
    public static class WinFormsHelpers
    {
        public static float GetDpiScaleFactor(this Control targetControl)
        {
            return targetControl.DeviceDpi / 96f;
        }
    }
}
