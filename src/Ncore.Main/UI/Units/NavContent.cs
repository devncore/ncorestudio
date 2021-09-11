using System.Windows;
using System.Windows.Controls;

namespace Ncore.Main.UI.Units
{
    public class NavContent : Control
    {
        #region DefaultStyleKey

        static NavContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavContent), new FrameworkPropertyMetadata(typeof(NavContent)));
        }
        #endregion
    }
}
