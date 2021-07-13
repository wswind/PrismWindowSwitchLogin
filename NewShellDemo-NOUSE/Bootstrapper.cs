using NewShellDemo.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace NewShellDemo
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var regionManager = Container.Resolve<IRegionManager>();
            return new MainWindow(regionManager);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
