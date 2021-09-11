using System.Windows;
using System.Windows.Controls;

namespace Ncore.Main.UI.Units
{
    public class MainMenuItem : ListBoxItem
    {
        #region DefaultStyleKey

        static MainMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenuItem), new FrameworkPropertyMetadata(typeof(MainMenuItem)));
        }
        #endregion
    }
}
