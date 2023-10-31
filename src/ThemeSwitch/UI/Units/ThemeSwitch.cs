using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ThemeSwitch.UI.Units
{
    public class ThemeSwitch : JamesToggleSwitch
    {
        static ThemeSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThemeSwitch), new FrameworkPropertyMetadata(typeof(ThemeSwitch)));
        }
    }
}
