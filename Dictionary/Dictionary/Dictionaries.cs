using System;
using System.Collections;
using System.Text;
using System.Reflection;
using System.IO;

namespace Dictionary
{
	class Dictionaries
	{
		private string path;
		private Dictionary[] dictionaries;
		public Dictionary Chosen;

		public Dictionaries()
		{
			path = /*Assembly.GetExecutingAssembly().Location;*/ Assembly.GetExecutingAssembly().GetName().CodeBase;
			path = path.Substring(0, path.LastIndexOf('\\') + 1);

			DirectoryInfo dir1 = new DirectoryInfo(path);
			FileInfo[] files1 = dir1.GetFiles("*.dict");
			FileInfo[] files2 = { };
			string path2 = path + "\\dicts";
			if(Directory.Exists(path2))
			{
				DirectoryInfo dir2 = new DirectoryInfo(path2);
				files2 = dir2.GetFiles("*.dict");
			}

			dictionaries = new Dictionary[files1.Length + files2.Length];
			int indexFiles1 = 0, indexFiles2 = 0, indexDictionaries = 0;

			while(true)
			{
				if(indexFiles1 < files1.Length)
				{
					if(indexFiles2 < files2.Length)
					{
						if(files1[indexFiles1].Name.CompareTo(files2[indexFiles2].Name) > 0)
						{
							AddDictionary(files2, indexFiles2++, indexDictionaries++);
						}
						else
						{
							AddDictionary(files1, indexFiles1++, indexDictionaries++);
						}
					}
					else
					{
						AddDictionary(files1, indexFiles1++, indexDictionaries++);
					}
				}
				else
				{
					if(indexFiles2 < files2.Length)
					{
						AddDictionary(files2, indexFiles2++, indexDictionaries++);
					}
					else
					{
						break;
					}
				}
			}
		}

		private void AddDictionary(FileInfo[] files, int indexFiles, int indexDictionaries)
		{
			string name = files[indexFiles].Name;
			string[] langs = name.Split('-');
			string lang2;
			if(langs[1].IndexOf("_") != -1)
			{
				lang2 = langs[1].Substring(0, langs[1].IndexOf('_'));
			}
			else
			{
				lang2 = langs[1].Substring(0, langs[1].IndexOf('.'));
			}
			dictionaries[indexDictionaries] = new Dictionary(langs[0], lang2, files[indexFiles].FullName);
		}

		public Dictionary this[int index]
		{
			get
			{
				return dictionaries[index];
			}
		}

		public int Length
		{
			get { return dictionaries.Length; }
		}
	}
}
