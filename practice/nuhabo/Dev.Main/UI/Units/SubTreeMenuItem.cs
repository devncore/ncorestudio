using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class SubTreeMenuItem : TreeViewItem
    {
        #region DefaultStyleKey

        static SubTreeMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubTreeMenuItem), new FrameworkPropertyMetadata(typeof(SubTreeMenuItem)));
        }

        #endregion

        #region GetContainerForItemOverride
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new SubTreeMenuItem();
        }
        #endregion
    }
}
