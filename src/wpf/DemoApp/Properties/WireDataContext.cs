using DemoApp.Local.ViewModels;
using DemoApp.UI.Views;
using Jamesnet.Wpf.Global.Location;

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
