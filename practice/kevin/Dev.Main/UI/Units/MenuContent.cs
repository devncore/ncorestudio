using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class MenuContent : Control
    {
        static MenuContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuContent), new FrameworkPropertyMetadata(typeof(MenuContent)));
        }
    }
}
