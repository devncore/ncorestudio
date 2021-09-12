using Ncore.Controls.Primitives;
using System.Windows;

namespace Ncore.LayoutSupport.Controls
{
    public class NcoreIcon : Icon
    {
        #region DefaultStyleKey

        static NcoreIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NcoreIcon), new FrameworkPropertyMetadata(typeof(NcoreIcon)));
        }
        #endregion
    }
}
