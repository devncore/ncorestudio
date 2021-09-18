using Dev.Data.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.DBGen
{
    public class MainMenuGen
    {
        public static List<MenuModel> GetMainMenus()
        {
            var source = new List<MenuModel>();

            source.Add(new MenuModel { Name = "홈" });
            source.Add(new MenuModel { Name = "사용자관리" });
            source.Add(new MenuModel { Name = "정보" });

            return source;
        }
    }
}
