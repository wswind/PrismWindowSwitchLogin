using NewShellDemo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace NewShellDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public DelegateCommand LoginCommand => new DelegateCommand(ExecuteLogin);

        private void ExecuteLogin()
        {
            
        }
    }
}
