using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Testing.WpfWithXamlIslands.Controls
{
    /// <summary>
    /// Interaction logic for OwnCustomSimpleUserControl.xaml
    /// </summary>
    public partial class OwnCustomSimpleUserControl : UserControl
    {
        public OwnCustomSimpleUserControl()
        {
            this.InitializeComponent();

            this.CtrlXamlHost.Child = new Testing.CustomUwpControls.SimpleUserControl();
        }
    }
}
