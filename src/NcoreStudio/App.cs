using System;
using System.Windows;
using Ncore.Foundation.Wpfbase;
using Ncore.Main.UI.Views;

namespace NcoreStudio
{
	public class App : NcoreApplication
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			_ = new MainWindow().ShowDialog();
			Environment.Exit(0);
		}
	}
}
