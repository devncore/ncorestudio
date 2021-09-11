using Dev.Data.Menus;
using Dev.DBGen;
using Dev.Foundation.Mvvm;
using System.Collections.Generic;

namespace Dev.Main.Local.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public List<MenuModel> Menus { get; set; }

        public MainViewModel()
        {
            Menus = MenuGen.GetMenus();
        }

    }
}
