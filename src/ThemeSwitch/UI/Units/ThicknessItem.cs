using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace ThemeSwitch.UI.Units
{
    public class ThicknessItem : ThicknessAnimation
    {
        #region TargetName

        public static readonly DependencyProperty TargetNameProperty = DependencyProperty.Register(
            "TargetName",
            typeof(string),
            typeof(ThicknessItem),
            new PropertyMetadata(null, OnTargetNameChanged)
        );

        public string TargetName
        {
            get { return (string)GetValue(TargetNameProperty); }
            set { SetValue(TargetNameProperty, value); }
        }
        #endregion

        #region Property

        public static readonly DependencyProperty PropertyProperty = DependencyProperty.Register(
            "Property",
            typeof(DependencyProperty),
            typeof(ThicknessItem),
            new PropertyMetadata(null, OnPropertyChanged)
        );

        public DependencyProperty Property
        {
            get { return (DependencyProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }
        #endregion

        private static void OnTargetNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thicknessItem = (ThicknessItem)d;
            var targetName = (string)e.NewValue;

            Storyboard.SetTargetName(thicknessItem, targetName);
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thicknessItem = (ThicknessItem)d;
            var property = (DependencyProperty)e.NewValue;

            Storyboard.SetTargetProperty(thicknessItem, new PropertyPath(property));
        }

        #region Mode

        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register(
            "Mode",
            typeof(EasingMode),
            typeof(ThicknessItem),
            new PropertyMetadata(EasingMode.EaseOut, OnEasingModeChanged)
        );

        public EasingMode Mode
        {
            get { return (EasingMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }
        #endregion

        private static void OnEasingModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thicknessItem = (ThicknessItem)d;
            var easingMode = (EasingMode)e.NewValue;

            if (thicknessItem.EasingFunction is CubicEase cubicEase)
            {
                cubicEase.EasingMode = easingMode;
            }
            else
            {
                thicknessItem.EasingFunction = new CubicEase { EasingMode = easingMode };
            }
        }
    }


}
