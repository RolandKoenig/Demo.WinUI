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

namespace Demo.XamlIslands.WpfWithXamlIslands.Controls
{
    /// <summary>
    /// Interaction logic for OwnInkCanvasControl.xaml
    /// </summary>
    public partial class OwnInkCanvasControl : UserControl
    {
        public OwnInkCanvasControl()
        {
            this.InitializeComponent();

            this.CtrlInkToolbar.TargetInkCanvas = this.CtrlInkCanvas;
        }
    }
}
