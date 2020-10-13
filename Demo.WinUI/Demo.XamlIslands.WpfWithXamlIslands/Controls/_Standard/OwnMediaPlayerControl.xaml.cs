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
using Windows.Media.Core;
using Microsoft.Win32;

namespace Demo.XamlIslands.WpfWithXamlIslands.Controls
{
    /// <summary>
    /// Interaction logic for OwnMediaPlayerControl.xaml
    /// </summary>
    public partial class OwnMediaPlayerControl : UserControl
    {
        public OwnMediaPlayerControl()
        {
            this.InitializeComponent();
        }

        private void OnMenuPlayFile_Click(object sender, RoutedEventArgs e)
        {
            var dlgOpenFile = new OpenFileDialog();
            if (true == dlgOpenFile.ShowDialog())
            {
                this.CtrlMediaPlayer.MediaPlayer.Source = MediaSource.CreateFromUri(new Uri(dlgOpenFile.FileName));
            }
        }
    }
}
