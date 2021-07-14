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
       
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

       
        public LoginWindowViewModel()
        {
            
        }

        public DelegateCommand LoginCommand => new DelegateCommand(ExecuteLogin);

        private void ExecuteLogin()
        {
            SwitchWindow?.Invoke();
        }

        public Action SwitchWindow;
    }
}
