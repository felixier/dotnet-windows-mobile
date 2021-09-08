using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lock
{
	class Program
	{
		static void Main(string[] args)
		{
			Process.Start(@"\Windows\QuickMenu.exe", "-c:1056");
			Process.Start(@"\Windows\QuickMenu.exe", "-c:1014");
		}
	}
}
