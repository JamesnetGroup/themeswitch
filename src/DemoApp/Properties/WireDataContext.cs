using DemoApp.Local.ViewModels;
using DemoApp.UI.Views;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Composition;
using Jamesnet.Wpf.Global.Location;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<DemoWindow, DemoWindowViewModel>();
        }
    }
}
