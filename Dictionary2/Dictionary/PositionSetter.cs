#region Using directives

using System;
using System.Windows.Forms;

#endregion

namespace Dictionary
{
	/// <summary>
	/// Summary description for PositionAndSizeSetter.
	/// </summary>
	public sealed class PositionAndSizeSetter
	{
		public static void DockToTopNeighbour(Control control, Control topNeighbour)
		{
			if (control.Dock == DockStyle.Bottom)
			{
				control.Height = control.Bottom - topNeighbour.Bottom;
			}
		}
	}
}
