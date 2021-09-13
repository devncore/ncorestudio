using Dev.Data.Menus;
using System.Collections.Generic;

namespace Dev.DBGen
{
    public class SubItemGen
    {
        public static List<TreeMenuModel> GetSubMenus(MenuModel menu)
        {
            var source = new List<TreeMenuModel>();

            if (menu.Name == "Assembly")
            {
                source.Add(new TreeMenuModel { Name = "Class" });
                source.Add(new TreeMenuModel { Name = "Method" });
                source.Add(new TreeMenuModel { Name = "Parameter" });
                source.Add(new TreeMenuModel { Name = "Arguments" });

                source[0].ChildItems = new List<TreeMenuModel>();
                source[0].ChildItems.Add(new TreeMenuModel { Name = "public" });
                source[0].ChildItems.Add(new TreeMenuModel { Name = "private" });
                source[0].ChildItems.Add(new TreeMenuModel { Name = "protected" });

                source[1].ChildItems = new List<TreeMenuModel>();
                source[1].ChildItems.Add(new TreeMenuModel { Name = "void" });
                source[1].ChildItems.Add(new TreeMenuModel { Name = "static" });

                source[3].ChildItems = new List<TreeMenuModel>();
                source[3].ChildItems.Add(new TreeMenuModel { Name = "main" });
                source[3].ChildItems.Add(new TreeMenuModel { Name = "sub" });


            }
            else
            {
                source.Add(new TreeMenuModel { Name = "String" });
                source.Add(new TreeMenuModel { Name = "DateTime" });
                source.Add(new TreeMenuModel { Name = "Int" });
            }

            return source;
        }
    }
}
