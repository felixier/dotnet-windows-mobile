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
		public static void DockToLeft(Control control, Form form)
		{
			control.Width = form.Width - control.Left;
		}

		public static void DockToBottom(Control control, Form form)
		{
			control.Height = form.Height - control.Top;
		}

		public static int CountSizeInRatio(int originalControlSize, int originalFormSize, int actualFormSize)
		{
			return (actualFormSize / originalFormSize) * originalFormSize;
		}
	}
}
