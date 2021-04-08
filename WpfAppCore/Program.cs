using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppCore
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new UwpApp1.App())
            {
                var app = new WpfAppCore.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
