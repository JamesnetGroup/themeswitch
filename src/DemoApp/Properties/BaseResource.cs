using Jamesnet.Wpf.Global.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Properties
{
    internal class BaseResource : BaseResourceInitializer
    {
        protected override string DetermineDefaultLocale() => "KOR";
        protected override string DetermineDefaultThemeName() => "Light";
        protected override string FetchLocalePath() => "DemoApp.Themes.Language.yaml";
        protected override string FetchThemePath() => "DemoApp.Themes.Theme.yaml";
    }
}
