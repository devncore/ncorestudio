using Dev.Data.Menus;
using Dev.DBGen;
using Dev.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
