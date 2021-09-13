using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class MainMenu : ListBox
    {
        #region DefaultStyleKey

        static MainMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
        }
        #endregion


        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MainMenuItem();
        }
        #endregion

    }
}
