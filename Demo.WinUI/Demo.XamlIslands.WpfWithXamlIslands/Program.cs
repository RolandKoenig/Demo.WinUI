using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.WpfWithXamlIslands
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (new Testing.UwpApp.App())
            {
                var app = new Testing.WpfWithXamlIslands.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
