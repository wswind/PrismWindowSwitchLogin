using ShellSwitchDemo2.ViewModels;
using System;
using System.Windows;

namespace ShellSwitchDemo2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            LoginWindowViewModel viewModel = DataContext as LoginWindowViewModel;
            viewModel.SwitchWindow += SwitchWindow;
        }

        private void SwitchWindow(Window shell)
        {
            if (shell != null)
            {
                Application.Current.MainWindow = shell;
                shell.Show();
                this.Close();
            }
        }
    }
}
