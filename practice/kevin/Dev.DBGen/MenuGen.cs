using Dev.Data.Menus;
using System.Collections.Generic;

namespace Dev.DBGen
{
    public class MenuGen 
    {
        public static List<MenuModel> GetMenus()
        {
            var source = new List<MenuModel>();
            source.Add(new MenuModel { Name = "Home"});
            source.Add(new MenuModel { Name = "Assembly"});
            source.Add(new MenuModel { Name = "Setting" });
            source.Add(new MenuModel { Name = "Help" });

            return source;
        }
    }
}
