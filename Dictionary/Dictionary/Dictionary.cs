using System;
using System.Collections;
using System.Text;
using Finisar.SQLite;

namespace Dictionary
{
	class Dictionary
	{
		enum DirectionTypes { Lang1toLang2, Lang2toLang1 }

		public readonly string Lang1;
		public readonly string Lang2;
		private readonly string path;
		private string name1;
		private string name2;
		private string actualName;
		private DirectionTypes direction = DirectionTypes.Lang1toLang2;
		private SQLiteConnection conn = null;
		private static string completeWord1 = "select lang1 from dict where lang1 >= ? and lang1 <= ? limit " + COMPLETE_WORD_ROWS_COUNT;
		private static string completeWord2 = "select lang2 from dict where lang2 >= ? and lang2 <= ? limit " + COMPLETE_WORD_ROWS_COUNT;
		private static string translateWord1 = "select lang2, notes, specnotes from dict where lang1 = ?";
		private static string translateWord2 = "select lang1, notes, specnotes from dict where lang2 = ?";
		private const int COMPLETE_WORD_ROWS_COUNT = 50;
		private const int TRANSLATED_WORDS_COUNT_EXPECTATION = 10;

		public Dictionary(string lang1, string lang2, string path)
		{
			this.Lang1 = lang1;
			this.Lang2 = lang2;
			this.path = path;
			this.name1 = string.Format("{0}-{1}", lang1, lang2);
			this.name2 = string.Format("{0}-{1}", lang2, lang1);
			actualName = name1;
		}

		private void Init()
		{
			conn = new SQLiteConnection(string.Format("Data Source={0};Version=3;", path));
		}

		public void Open()
		{
			if(conn == null)
			{
				Init();
			}
			if(conn.State == System.Data.ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		public void Close()
		{
			if(conn != null)
			{
				if(conn.State != System.Data.ConnectionState.Closed)
				{
					conn.Close();
				}
			}
		}

		public void Switch()
		{
			if(direction == DirectionTypes.Lang1toLang2)
			{
				direction = DirectionTypes.Lang2toLang1;
				actualName = name2;
			}
			else
			{
				direction = DirectionTypes.Lang1toLang2;
				actualName = name1;
			}
		}

		public ArrayList CompleteWord(string word)
		{
			CheckState();
			SQLiteCommand cmd;
			if(direction == DirectionTypes.Lang1toLang2)
			{
				cmd = new SQLiteCommand(completeWord1, conn);
			}
			else
			{
				cmd = new SQLiteCommand(completeWord2, conn);
			}

			ArrayList results = new ArrayList(COMPLETE_WORD_ROWS_COUNT);
			SQLiteParameter parm = new SQLiteParameter();
			SQLiteParameter parm2 = new SQLiteParameter();
			parm.Value = word;
			parm2.Value = word + char.MaxValue;
			cmd.Parameters.Add(parm);
			cmd.Parameters.Add(parm2);
			string previousResult = "";

			using(SQLiteDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
			{
				while(rdr.Read())
				{
					string result = rdr[0].ToString();
					if(string.Compare(result, previousResult) != 0)
					{
						results.Add(result);
					}
					previousResult = rdr[0].ToString();
				}
			}
			return results;
		}

		public ArrayList TranslateWord(string word)
		{
			CheckState();
			SQLiteCommand cmd;
			if(direction == DirectionTypes.Lang1toLang2)
			{
				cmd = new SQLiteCommand(translateWord1, conn);
			}
			else
			{
				cmd = new SQLiteCommand(translateWord2, conn);
			}

			ArrayList results = new ArrayList(TRANSLATED_WORDS_COUNT_EXPECTATION);
			SQLiteParameter parm = new SQLiteParameter();
			parm.Value = word;
			cmd.Parameters.Add(parm);

			using(SQLiteDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
			{
				while(rdr.Read())
				{
					results.Add(new TranslatedItem(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString()));
				}
			}
			return results;
		}

		private void CheckState()
		{
			if(conn == null || conn.State == System.Data.ConnectionState.Closed)
			{
				Open();
			}
		}

		public string Name
		{
			get { return name1; }
		}

		public string ActualName
		{
			get { return actualName; }
		}
	}
}
