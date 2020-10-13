using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Demo.WinFormsWithXamlIslands
{
    public class ControlMetaInfo
    {
        private readonly Type _controlType;

        public ControlMetaInfo(Type controlType)
        {
            _controlType = controlType;
        }

        public override string ToString() => _controlType.Name;

        public UIElement CreateXamlUIElement()
        {
            return Activator.CreateInstance(_controlType) as UIElement;
        }
    }
}
