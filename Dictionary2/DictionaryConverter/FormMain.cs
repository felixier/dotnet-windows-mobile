using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace DictionaryConverter
{
	public partial class FormMain : Form
	{
		private const string CREATE_DICT_TABLE = "CREATE TABLE Dict (lang1 TEXT, lang2 TEXT, notes TEXT, specnotes TEXT);" +
												 "CREATE INDEX ilang1 ON Dict(lang1 ASC);" +
												 "CREATE INDEX ilang2 ON Dict(lang2 ASC)";
		private const string INSERT_A_ROW = "INSERT INTO Dict(lang1, lang2, notes, specnotes) VALUES(?, ?, ?, ?)";
		private const string DELETE_DUPLICATE_ROWS = "DELETE FROM Dict WHERE rowid NOT IN (SELECT MAX(rowid) FROM Dict GROUP BY lang1, lang2, notes, specnotes);" +
													 "VACUUM";

		/// <summary>
		/// Initializes a new instance of the <see cref="FormMain"/> class.
		/// </summary>
		public FormMain()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event of the browse control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void browse_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				dictFile.Text = openFileDialog1.FileName;
			}
		}

		/// <summary>
		/// The language name changed.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void languageNameChanged(object sender, EventArgs e)
		{
			string dictFileOutName = string.Format("{0}-{1}.dict", firstLang.Text, secondLang.Text);
			int i = 2;
			while(File.Exists(dictFileOutName))
			{
				dictFileOutName = string.Format("{0}-{1}_{2}.dict", firstLang.Text, secondLang.Text, i);
				i++;
			}
			dictFileOut.Text = dictFileOutName;
		}

		/// <summary>
		/// Handles the Click event of the convertButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void convertButton_Click(object sender, EventArgs e)
		{
			if(firstLang.Text.Length == 0 || secondLang.Text.Length == 0)
			{
				MessageBox.Show("Both languages names must be set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(File.Exists(dictFileOut.Text))
			{
				MessageBox.Show(string.Format("The file {0} already exists!", dictFileOut.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Convert();
				MessageBox.Show("Conversion finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		/// <summary>
		/// Converts the dictionary.
		/// </summary>
		private void Convert()
		{
			using(StreamReader rdr = new StreamReader(dictFile.Text))
			{
				SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0}", dictFileOut.Text));
				conn.Open();
				using(SQLiteTransaction mytransaction = conn.BeginTransaction())
				{
					using(SQLiteCommand cmd = new SQLiteCommand(conn))
					{
						cmd.CommandText = CREATE_DICT_TABLE;
						cmd.ExecuteNonQuery();

						SQLiteParameter[] parms = new SQLiteParameter[4];
						for(int i = 0; i < 4; i++)
						{
							parms[i] = new SQLiteParameter();
							cmd.Parameters.Add(parms[i]);
						}

						cmd.CommandText = INSERT_A_ROW;
						while(!rdr.EndOfStream)
						{
							string[] line = rdr.ReadLine().Split('\t');
							if(line.Length < 2)
							{
								continue;
							}
							ParseLine(cmd, parms, line);
						}
					}
					mytransaction.Commit();
				}

				using(SQLiteCommand cmd = new SQLiteCommand(conn))
				{
					if(checkBoxRemDup.Checked)
					{
						RemoveDuplicates(cmd);
					}
				}

				conn.Close();
			}
		}

		private static void RemoveDuplicates(SQLiteCommand cmd)
		{
			cmd.CommandText = DELETE_DUPLICATE_ROWS;
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Parses the line of the text file.
		/// </summary>
		/// <param name="cmd">The command.</param>
		/// <param name="parms">The Parameters.</param>
		/// <param name="line">The line of the text file.</param>
		private static void ParseLine(SQLiteCommand cmd, SQLiteParameter[] parms, string[] line)
		{
			string col3 = null, col4 = null;
			if(line.Length > 2)
			{
				try
				{
					col3 = line[2];
					col4 = line[3];
				}
				catch(IndexOutOfRangeException) { }
			}
			if(line[0].Contains(";") || line[1].Contains(";"))
			{
				string[] col1 = line[0].Split(';');
				string[] col2 = line[1].Split(';');
				for(int i = 0; i < col1.Length; i++)
				{
					for(int j = 0; j < col2.Length; j++)
					{
						InsertRow(cmd, parms, col1[i], col2[j], col3, col4);
					}
				}
			}
			else
			{
				InsertRow(cmd, parms, line[0], line[1], col3, col4);
			}
		}

		/// <summary>
		/// Inserts the row.
		/// </summary>
		/// <param name="cmd">The command.</param>
		/// <param name="parms">The parameters.</param>
		/// <param name="col1">The first column.</param>
		/// <param name="col2">The second column.</param>
		/// <param name="col3">The third column.</param>
		/// <param name="col4">The forth column.</param>
		private static void InsertRow(SQLiteCommand cmd, SQLiteParameter[] parms, string col1, string col2, string col3, string col4)
		{
			parms[0].Value = col1.Trim();
			parms[1].Value = col2.Trim();
			if(col3 != null)
			{
				parms[2].Value = col3.Trim();
			}
			if(col4 != null)
			{
				parms[3].Value = col4.Trim();
			}
			cmd.ExecuteNonQuery();
		}
	}
}