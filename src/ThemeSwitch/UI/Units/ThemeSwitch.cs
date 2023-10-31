using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

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
