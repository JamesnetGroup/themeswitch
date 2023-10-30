﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace ThemeSwitch.UI.Units
{
    public class ColorItem : ColorAnimation
    {
        #region TargetName

        public static readonly DependencyProperty TargetNameProperty = DependencyProperty.Register(
            "TargetName",
            typeof(string),
            typeof(ColorItem),
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
            typeof(PropertyPath),
            typeof(ColorItem),
            new PropertyMetadata(null, OnPropertyChanged)
        );

        public PropertyPath Property
        {
            get { return (PropertyPath)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }
        #endregion

        private static void OnTargetNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var item = (ColorItem)d;
            var targetName = (string)e.NewValue;

            Storyboard.SetTargetName(item, targetName);
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var item = (ColorItem)d;
            var propertyPath = (PropertyPath)e.NewValue;

            Storyboard.SetTargetProperty(item, propertyPath);
        }

        #region Mode

        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register(
            "Mode",
            typeof(EasingMode),
            typeof(ColorItem),
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
            var item = (ColorItem)d;
            var easingMode = (EasingMode)e.NewValue;

            if (item.EasingFunction is CubicEase cubicEase)
            {
                cubicEase.EasingMode = easingMode;
            }
            else
            {
                item.EasingFunction = new CubicEase { EasingMode = easingMode };
            }
        }
    }


}
