using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Ncore.Controls.Utils
{
	public static class GeometryExtend
	{
		#region ToGeometry

		public static Geometry ToGeometry(this string geometryString)
		{
			return Geometry.Parse(geometryString);
		}
		#endregion
	}
}
