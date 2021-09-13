using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class MenuContent : Control
    {
        #region DefaultStyleKey

        static MenuContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuContent), new FrameworkPropertyMetadata(typeof(MenuContent)));
        }
        #endregion
    }
}
