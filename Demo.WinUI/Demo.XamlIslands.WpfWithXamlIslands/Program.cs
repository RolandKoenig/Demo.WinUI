using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.XamlIslands.WpfWithXamlIslands
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (new Demo.XamlIslands.UwpApp.App())
            {
                var app = new Demo.XamlIslands.WpfWithXamlIslands.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
