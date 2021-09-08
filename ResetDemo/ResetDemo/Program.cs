#define PDA_TOM

using System;

namespace ResetDemo
{
	class RegKey
	{
		static Item[] RegKeysTable = new Item[]
		{
			// sp
			new Item("35629800006653000", "0D8686D8-7FEF-D097-7489-EE00691D8147", "74086D87-F7DE-D046-1899-7EE0691D08F8"),
			// pda
			new Item("35884502035063901", "A4171711-C727-4A8C-EBA2-72CC7274A7BE", "EBC1711C-7E42-4AB7-7A82-C27C7274A17A"),
		};

		static void Main()
		{
			string imei = TapiConnector.GetImei();
			foreach(Item item in RegKeysTable)
			{
				if (item.Imei == imei)
				{
					item.DeleteKeys();
					break;
				}
			}
		}
	}
}