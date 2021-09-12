using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Menus
{
    public class TreeMenuModel : MenuModel
    {
        public List<TreeMenuModel> ChildItems { get; set; }
    }
}
