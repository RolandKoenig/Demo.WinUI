using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.XamlHost;

namespace Testing.WinFormsWithXamlIslands.Controls
{
    public partial class OwnCustomSimpleUserControl : OwnXamlControlBase<WindowsXamlHost>
    {
        public OwnCustomSimpleUserControl()
        {
            this.InitializeComponent();
        }

        /// <inheritdoc />
        protected override WindowsXamlHost CreateXamlControl()
        {
            var result = new WindowsXamlHost();
            result.Child = new Testing.CustomUwpControls.SimpleUserControl();

            return result;
        }
    }
}
