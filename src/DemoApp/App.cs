using DemoApp.UI.Views;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace DemoApp
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new DemoWindow();
        }
    }
}
