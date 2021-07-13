using LoginBefore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoginBefore.Views
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            this.Loaded += LoginWindow_Loaded;
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoginWindowViewModel viewModel = DataContext as LoginWindowViewModel;
            viewModel.ChangeWindow += ChangeWindow;
        }

        private void ChangeWindow(Window shell)
        {
            if(shell != null)
            {
                Application.Current.MainWindow = shell;
                shell.Show();
                this.Close();
            }
        }

      
    }
}
