using System;

using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace ResetDemo
{
	class Item
	{
		public string Imei { get; private set; }
		public string Key1 { get; private set; }
		public string Key2 { get; private set; }

		public Item(string imei, string key1, string key2)
		{
			this.Imei = imei;
			this.Key1 = key1;
			this.Key2 = key2;
		}

		public void DeleteKeys()
		{
			DeleteKeys(Key1, Key2);
		}

		private static void DeleteKeys(string key1, string key2)
		{
			try
			{
				Registry.ClassesRoot.DeleteSubKeyTree(CompleteKey(key1));
			}
			catch { }
			try
			{
				Registry.ClassesRoot.DeleteSubKeyTree(CompleteKey(key2));
			}
			catch { }
		}

		private static string CompleteKey(string key)
		{
			return @"CLSID\{" + key + "}";
		}
	}
}
