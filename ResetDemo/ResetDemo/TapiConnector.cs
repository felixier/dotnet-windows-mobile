using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

using OpenNETCF.Tapi;

namespace ResetDemo
{
	static class TapiConnector
	{
		[DllImport("cellcore.dll")]
		private static extern int lineGetGeneralInfo(IntPtr hLine, byte[] bCache);

		/// <summary>
		/// Get the imei.
		/// </summary>
		/// <returns>imei</returns>
		internal static string GetImei()
		{
			string imei;

			Tapi t = new Tapi();
			t.Initialize();

			Line line = t.CreateLine(0, LINEMEDIAMODE.INTERACTIVEVOICE, LINECALLPRIVILEGE.MONITOR);

			byte[] buffer = new byte[512];
			//write size
			BitConverter.GetBytes(512).CopyTo(buffer, 0);

			if(lineGetGeneralInfo(line.hLine, buffer) != 0)
			{
				throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "TAPI Error: " + System.Runtime.InteropServices.Marshal.GetLastWin32Error().ToString("X"));
			}

			int serialsize = BitConverter.ToInt32(buffer, 36);
			int serialoffset = BitConverter.ToInt32(buffer, 40);
			imei = System.Text.Encoding.Unicode.GetString(buffer, serialoffset, serialsize);
			imei = imei.Substring(0, imei.IndexOf(Convert.ToChar(0)));

			line.Dispose();
			t.Shutdown();

			return imei;
		}
	}
}
