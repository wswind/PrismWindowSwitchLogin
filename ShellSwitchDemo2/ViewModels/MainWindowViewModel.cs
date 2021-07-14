using Prism.Mvvm;

namespace ShellSwitchDemo2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Main Window";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
