using System.Windows;
using System.Windows.Controls;

namespace Dev.Main.UI.Units
{
    public class SubTreeMenu : Control
    {
        #region DefaultStyleKey

        static SubTreeMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubTreeMenu), new FrameworkPropertyMetadata(typeof(SubTreeMenu)));
        }
        #endregion
    }
}
