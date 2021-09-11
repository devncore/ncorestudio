using Dev.Main.Local.ViewModels;
using System.Windows;

namespace Dev.Main.UI.Views
{
    public class MainWindow : Window
    {
        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }

        public MainWindow()
        {
            DataContext = new MainViewModel();
        }
    }
}
