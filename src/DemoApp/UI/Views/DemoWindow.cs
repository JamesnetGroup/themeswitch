using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

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
