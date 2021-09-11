using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class MainMenu : ListBox
    {
        static MainMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MainMenuItem();
        }

    }
}
