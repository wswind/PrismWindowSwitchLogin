using LoginBefore.Views;
using Prism.Ioc;
using System.Windows;

namespace LoginBefore
{
    /// <summary>
    /// https://stackoverflow.com/a/57097327/7726468
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<LoginWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
