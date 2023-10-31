using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ThemeSwitch.UI.Units
{
    public class ThemeSwitch : JamesToggleSwitch
    {
        static ThemeSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThemeSwitch), new FrameworkPropertyMetadata(typeof(ThemeSwitch)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();


            // Storyboard를 찾음
            var slideOutStoryboard = this.FindResource("SlideOut") as Storyboard;
            if (slideOutStoryboard != null)
            {
                // Storyboard를 사용함
                slideOutStoryboard.Begin(this, this.Template, true);
            }
        }
    }
}
