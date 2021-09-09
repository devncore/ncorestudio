using System.Windows;
using Ncore.Main.Local.ViewModels;

namespace Ncore.Main.UI.Views
{
	public class MainWindow : Window
	{
		#region DefaultStyleKey

		static MainWindow()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
		}
		#endregion

		#region Constructor

		public MainWindow()
		{
			DataContext = new MainViewModel();
		}
		#endregion
	}
}
