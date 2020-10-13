using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;

namespace Demo.XamlIslands.WinFormsWithXamlIslands.Controls
{
    public partial class OwnMapControl : OwnXamlControlBase<MapControl>
    {
        public OwnMapControl()
        {
            InitializeComponent();
        }

        protected override MapControl CreateXamlControl()
        {
            return new MapControl();
        }
    }
}
