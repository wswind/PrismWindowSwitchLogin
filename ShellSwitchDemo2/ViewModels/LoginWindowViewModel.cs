using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using ShellSwitchDemo2.Views;
using System;
using System.Windows;

namespace ShellSwitchDemo2.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        private string _title = "Login Window";
        private IContainerExtension _container;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

       
        public LoginWindowViewModel(IContainerExtension container)
        {
            _container = container;
        }

        public DelegateCommand LoginCommand => new DelegateCommand(ExecuteLogin);

        private void ExecuteLogin()
        {
            var shell = _container.Resolve<MainWindow>();
            SwitchWindow?.Invoke(shell);
        }

        public Action<Window> SwitchWindow;
    }
}
