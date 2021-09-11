using Dev.Foundation.Wpfbase;
using Dev.Main.UI.Views;
using System;
using System.Windows;

namespace DevStudio
{
    public class App : DevApplication
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            _ = new MainWindow().ShowDialog();
            Environment.Exit(0);
        }
    }
}
