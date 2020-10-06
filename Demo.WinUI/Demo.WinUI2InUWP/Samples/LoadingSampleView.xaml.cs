using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Demo.Shared.Samples;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Demo.WinUI2InUWP.Samples
{
    public sealed partial class LoadingSampleView : Page
    {
        public LoadingSampleViewModel ViewModel => this.DataContext as LoadingSampleViewModel;

        public LoadingSampleView()
        {
            this.InitializeComponent();
        }
    }
}
