using Prism.Regions;
using System.Windows;

namespace NewShellDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            RegionManager = regionManager;
            InitializeComponent();
        }

        public IRegionManager RegionManager { get; private set; }
    }
}
