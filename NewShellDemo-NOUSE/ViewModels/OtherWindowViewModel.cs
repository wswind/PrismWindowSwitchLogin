using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace NewShellDemo.ViewModels
{
    public class OtherWindowViewModel : BindableBase
    {

        public OtherWindowViewModel(IRegionManager regionManager)
        {

        }

        public DelegateCommand CreateNewShellCommand => new DelegateCommand(ExecuteCreateNewShellCommand);


        private void ExecuteCreateNewShellCommand()
        {
            // I am assuming you have a reference to the DI container

            var newRegionManager = _regionManager.CreateRegionManager();
            var shell = new MainWindow(newRegionManager);

            // The rest is easy, for example:
            shell.Show();
        }
    }
}
