using LoginBefore.Views;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Windows;

namespace LoginBefore.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        public LoginWindowViewModel(IContainerExtension container)
        {
            _container = container;
        }

        public DelegateCommand LoginCommand => new DelegateCommand(ExecuteLogin);


        private void ExecuteLogin()
        {
            var shell = _container.Resolve<MainWindow>();
            ChangeWindow?.Invoke(shell);
        }

        public Action<Window> ChangeWindow;
        private IContainerExtension _container;
    }
}
