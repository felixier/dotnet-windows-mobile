using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace Dictionary
{
	class Dictionary : IDisposable
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
		private static string completeWord1 = "select lang1 from dict where lang1 >= ? and lang1 <= ? order by lang1 limit " + CompleteWordRowsCount;
		private static string completeWord2 = "select lang2 from dict where lang2 >= ? and lang2 <= ? order by lang2 limit " + CompleteWordRowsCount;
		private const string translateWord1 = "select lang2, notes, specnotes from dict where lang1 = ? order by lang2, notes, specnotes";
		private const string translateWord2 = "select lang1, notes, specnotes from dict where lang2 = ? order by lang1, notes, specnotes";
		private const int CompleteWordRowsCount = 100;
		private const int TranslatedWordsExpectedCount = 30;

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

		/// <summary>
		/// Opens the connection.
		/// </summary>
		public void Open()
		{
			if (conn == null)
			{
				Init();
			}
			if (conn.State == System.Data.ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		/// <summary>
		/// Closes the connection.
		/// </summary>
		public void Close()
		{
			if (conn != null)
			{
				if (conn.State != System.Data.ConnectionState.Closed)
				{
					conn.Close();
					conn.Dispose();
				}
			}
		}

		#region IDisposable Members

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Close();
		}

		#endregion

		public void Switch()
		{
			if (direction == DirectionTypes.Lang1toLang2)
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

		public List<string> CompleteWord(string word)
		{
			CheckState();
			SQLiteCommand cmd;
			if (direction == DirectionTypes.Lang1toLang2)
			{
				cmd = new SQLiteCommand(completeWord1, conn);
			}
			else
			{
				cmd = new SQLiteCommand(completeWord2, conn);
			}

			List<string> results = new List<string>(CompleteWordRowsCount);
			SQLiteParameter parm = new SQLiteParameter();
			SQLiteParameter parm2 = new SQLiteParameter();
			parm.Value = word;
			parm2.Value = word + char.MaxValue;
			cmd.Parameters.Add(parm);
			cmd.Parameters.Add(parm2);
			string previousResult = string.Empty;

			using (SQLiteDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
			{
				while (rdr.Read())
				{
					string result = rdr[0].ToString();
					if (string.Compare(result, previousResult, StringComparison.Ordinal) != 0)
					{
						results.Add(result);
					}
					previousResult = rdr[0].ToString();
				}
			}
			return results;
		}

		public List<TranslatedItem> TranslateWord(string word)
		{
			CheckState();
			SQLiteCommand cmd;
			if (direction == DirectionTypes.Lang1toLang2)
			{
				cmd = new SQLiteCommand(translateWord1, conn);
			}
			else
			{
				cmd = new SQLiteCommand(translateWord2, conn);
			}

			List<TranslatedItem> results = new List<TranslatedItem>(TranslatedWordsExpectedCount);
			SQLiteParameter parm = new SQLiteParameter();
			parm.Value = word;
			cmd.Parameters.Add(parm);

			using (SQLiteDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
			{
				while (rdr.Read())
				{
					results.Add(new TranslatedItem(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString()));
				}
			}
			return results;
		}

		private void CheckState()
		{
			if (conn == null || conn.State == System.Data.ConnectionState.Closed)
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
