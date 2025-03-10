using Jamesnet.Wpf.Controls;
using System.Windows;

namespace DemoApp.UI.Views
{
    public class DemoWindow : DarkThemeWindow
    {
        static DemoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DemoWindow), new FrameworkPropertyMetadata(typeof(DemoWindow)));
        }
    }
}
