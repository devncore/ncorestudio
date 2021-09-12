using Dev.Data.Menus;
using System.Collections.Generic;

namespace Dev.DBGen
{
    public class MainMenuGen
    {
        public static List<MenuModel> GetMainMenus()
        {
            var source = new List<MenuModel>();
            source.Add(new MenuModel { Name = "Home" });
            source.Add(new MenuModel { Name = "Assembly" });
            source.Add(new MenuModel { Name = "Setting" });
            source.Add(new MenuModel { Name = "Help" });

            return source;
        }
    }
}
