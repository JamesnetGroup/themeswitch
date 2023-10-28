using Jamesnet.Wpf.Controls;
using System.Windows;

namespace DemoApp
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
