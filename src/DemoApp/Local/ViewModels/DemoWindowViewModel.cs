using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Composition;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Local.ViewModels
{
    internal partial class DemoWindowViewModel : ObservableBase
    {
        private readonly ResourceManager _resourceManager;
        [ObservableProperty]
        private bool _isThemeChecked;

        public DemoWindowViewModel(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        partial void OnIsThemeCheckedChanged(bool value)
        {
            string name = value == true ? "Black" : "Light";
            _resourceManager.SwitchTheme(name);
        }
    }
}
