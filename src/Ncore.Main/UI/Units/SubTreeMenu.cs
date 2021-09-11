using System.Windows;
using System.Windows.Controls;

namespace Ncore.Main.UI.Units
{
    public class SubTreeMenu : TreeView
    {
        #region DefaultStyleKey

        static SubTreeMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubTreeMenu), new FrameworkPropertyMetadata(typeof(SubTreeMenu)));
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
