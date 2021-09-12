using Dev.Data.Menus;
using Dev.DBGen;
using Dev.Foundation.Mvvm;
using System.Collections.Generic;

namespace Dev.Main.Local.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        #region Variables

        private List<TreeMenuModel> _subItems;
        private MenuModel _currentMainMenu;

        #endregion

        #region MainMenus

        public List<MenuModel> MainMenus { get; set; }

        #endregion

        #region CurrentMainMenu

        public MenuModel CurrentMainMenu
        {
            get => _currentMainMenu;
            set { _currentMainMenu = value; OnPropertyChanged(); MainMenuChanged(value); }
        }

        #endregion

        #region SubItems

        public List<TreeMenuModel> SubItems 
        {
            get => _subItems; 
            set { _subItems = value; OnPropertyChanged(); }
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            MainMenus = MainMenuGen.GetMainMenus();
        }

        #endregion

        #region MainMenuChanged

        private void MainMenuChanged(MenuModel value)
        {
            SubItems = SubItemGen.GetSubMenus(value);
        }

        #endregion
    }
}
