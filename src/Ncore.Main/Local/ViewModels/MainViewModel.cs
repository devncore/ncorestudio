using Ncore.Data.Menus;
using Ncore.DBGen;
using Ncore.Foundation.Mvvm;
using System.Collections.Generic;

namespace Ncore.Main.Local.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		#region MainMenus

		public List<MenuModel> MainMenus { get; set; }
		#endregion

		#region Constructor

		public MainViewModel()
		{
			MainMenus = MainMenuGen.GetMainMenus();
		}
		#endregion
	}
}
