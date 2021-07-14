using Prism.Commands;
using Prism.Mvvm;
using ShellSwitchDemo.Views;
using System.Windows;

namespace ShellSwitchDemo.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        public DelegateCommand LoginCommand { get; set; } = new DelegateCommand(ExecuteLogin);

        private static void ExecuteLogin()
        {
            MessageBox.Show("login");

            ShellSwitcher.Switch<LoginView, MainWindow>();
        }
    }
}
