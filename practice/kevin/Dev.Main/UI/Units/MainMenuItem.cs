using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class MainMenuItem : ListBoxItem
    {
        static MainMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenuItem), new FrameworkPropertyMetadata(typeof(MainMenuItem)));
        }
    }
}
