using NewShellDemo.Views;
using Prism.Ioc;
using System.Windows;

namespace NewShellDemo
{
    /// <summary>
    /// this demo is not used
    /// https://stackoverflow.com/questions/5276984/how-to-do-multiple-shells-in-my-prism-app-like-ms-office
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
