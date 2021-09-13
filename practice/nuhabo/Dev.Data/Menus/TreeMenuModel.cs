using System.Collections.Generic;

namespace Dev.Data.Menus
{
    public class TreeMenuModel : MenuModel
    {
        public List<TreeMenuModel> ChildItems { get; set; }
    }
}
