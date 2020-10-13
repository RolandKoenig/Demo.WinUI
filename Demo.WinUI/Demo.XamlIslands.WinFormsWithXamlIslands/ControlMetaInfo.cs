using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Demo.XamlIslands.WinFormsWithXamlIslands
{
    public class ControlMetaInfo
    {
        private readonly Type _controlType;

        public ControlMetaInfo(Type controlType)
        {
            _controlType = controlType;
        }

        public override string ToString() => _controlType.Name;

        public Control CreateControl()
        {
            return (Control)Activator.CreateInstance(_controlType);
        }
    }
}
