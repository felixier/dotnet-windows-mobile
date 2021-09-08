#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

#endregion

namespace Dictionary
{
	/// <summary>
	/// Summary description for form.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private Dictionaries dictionaries = new Dictionaries();
		private TextBox textBoxTranslate;
		private MenuItem menuItemTranslate;
		private ListView listViewTranslate;
		private ColumnHeader columnHeaderTranslate;
		private bool textBoxTranslateChanged = true;
		private MenuItem menuItemMenu;
		private MenuItem menuItemLine;
		private MenuItem menuItemExit;
		private MenuItem menuItemClear;
		private MenuItem menuItemSwitch;
		/// <summary>
		/// Main menu for the form.
		/// </summary>
		private System.Windows.Forms.MainMenu mainMenu1;

		public FormMain()
		{
			InitializeComponent();
			InitializeMenu();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			dictionaries.Dispose();
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="FormMain"/> is reclaimed by garbage collection.
		/// </summary>
		~FormMain()
		{
			dictionaries.Dispose();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemTranslate = new System.Windows.Forms.MenuItem();
			this.menuItemMenu = new System.Windows.Forms.MenuItem();
			this.menuItemLine = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemClear = new System.Windows.Forms.MenuItem();
			this.menuItemSwitch = new System.Windows.Forms.MenuItem();
			this.textBoxTranslate = new System.Windows.Forms.TextBox();
			this.listViewTranslate = new System.Windows.Forms.ListView();
			this.columnHeaderTranslate = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItemTranslate);
			this.mainMenu1.MenuItems.Add(this.menuItemMenu);
			// 
			// menuItemTranslate
			// 
			this.menuItemTranslate.Text = global::Dictionary.DictionaryStrings.Translate;
			this.menuItemTranslate.Click += new System.EventHandler(this.menuItemTranslate_Click);
			// 
			// menuItemMenu
			// 
			this.menuItemMenu.Text = global::Dictionary.DictionaryStrings.Menu;
			// 
			// menuItemLine
			// 
			this.menuItemLine.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Text = global::Dictionary.DictionaryStrings.Exit;
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemClear
			// 
			this.menuItemClear.Text = global::Dictionary.DictionaryStrings.Clear;
			this.menuItemClear.Click += new System.EventHandler(this.menuItemClear_Click);
			// 
			// menuItemSwitch
			// 
			this.menuItemSwitch.Text = global::Dictionary.DictionaryStrings.Switch;
			this.menuItemSwitch.Click += new System.EventHandler(this.menuItemSwitch_Click);
			// 
			// textBoxTranslate
			// 
			this.textBoxTranslate.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.textBoxTranslate.Location = new System.Drawing.Point(0, 0);
			this.textBoxTranslate.Name = "textBoxTranslate";
			this.textBoxTranslate.Size = new System.Drawing.Size(240, 30);
			this.textBoxTranslate.TabIndex = 1;
			this.textBoxTranslate.TextChanged += new System.EventHandler(this.textBoxTranslate_TextChanged);
			this.textBoxTranslate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTranslate_KeyPress);
			// 
			// listViewTranslate
			// 
			this.listViewTranslate.Columns.Add(this.columnHeaderTranslate);
			this.listViewTranslate.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listViewTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.listViewTranslate.FullRowSelect = true;
			this.listViewTranslate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTranslate.Location = new System.Drawing.Point(0, 23);
			this.listViewTranslate.Name = "listViewTranslate";
			this.listViewTranslate.Size = new System.Drawing.Size(240, 243);
			this.listViewTranslate.TabIndex = 0;
			this.listViewTranslate.View = System.Windows.Forms.View.Details;
			this.listViewTranslate.GotFocus += new System.EventHandler(this.listViewTranslate_GotFocus);
			this.listViewTranslate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTranslate_Key);
			// 
			// columnHeaderTranslate
			// 
			this.columnHeaderTranslate.Text = "ColumnHeader";
			this.columnHeaderTranslate.Width = 230;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(240, 266);
			this.Controls.Add(this.listViewTranslate);
			this.Controls.Add(this.textBoxTranslate);
			this.Menu = this.mainMenu1;
			this.Name = "FormMain";
			this.Text = global::Dictionary.DictionaryStrings.Dictionary;
			this.Resize += new System.EventHandler(this.FormMain_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		#region private methods

		private void DebugFill()
		{
			textBoxTranslate.Text = "debug text";
			for (int i = 0; i < 15; i++)
			{
				listViewTranslate.Items.Add(new ListViewItem("debug text debug text debug text debug text debug text"));
			}
			listViewTranslate.Focus();
		}

		private void InitializeMenu()
		{
			for (int i = 0; i < dictionaries.Length; i++)
			{
				MenuItem m = new MenuItem();
				m.Text = dictionaries[i].Name;
				m.Click += new EventHandler(this.menuItemDict_Click);
				menuItemMenu.MenuItems.Add(m);
			}
			if (dictionaries.Length > 0)
			{
				menuItemMenu.MenuItems.Add(menuItemLine);
				menuItemMenu.MenuItems.Add(menuItemSwitch);
				menuItemMenu.MenuItems.Add(menuItemClear);
				ChooseDictionary(dictionaries[0]);
			}
			else
			{
				textBoxTranslate.Text = DictionaryStrings.NoDictionary;
				textBoxTranslate.Enabled = false;
				listViewTranslate.Enabled = false;
				menuItemTranslate.Enabled = false;
			}
			menuItemMenu.MenuItems.Add(menuItemExit);
			textBoxTranslate.Focus();
		}

		private void ChooseDictionary(Dictionary dict)
		{
			if (dictionaries.Chosen != null)
			{
				dictionaries.Chosen.Close();
			}
			dictionaries.Chosen = dict;
			WriteName();
		}

		/// <summary>
		/// Writes the name of current dictionary.
		/// </summary>
		private void WriteName()
		{
			this.Text = DictionaryStrings.Dictionary + " " + dictionaries.Chosen.ActualName;
		}

		private void CompleteWord()
		{
			if (textBoxTranslate.Text.Length > 0)
			{
				listViewTranslate.Items.Clear();
				List<string> completedWord = dictionaries.Chosen.CompleteWord(textBoxTranslate.Text);
				foreach (string word in completedWord)
				{
					listViewTranslate.Items.Add(new ListViewItem(word));
				}
				listViewTranslate.Focus();
			}
		}

		private void ShowTranslation()
		{
			if (listViewTranslate.FocusedItem == null)
			{
				textBoxTranslate.Focus();
			}
			else
			{
				new FormTranslation(this, listViewTranslate.FocusedItem.Text, dictionaries.Chosen).Show();
				this.Hide();
			}
		}

		#endregion

		#region event handlers

		private void listViewTranslate_GotFocus(object sender, EventArgs e)
		{
			if (textBoxTranslateChanged)
			{
				try
				{
					listViewTranslate.Items[0].Selected = true;
					listViewTranslate.Items[0].Focused = true;
					columnHeaderTranslate.Width = listViewTranslate.ClientSize.Width;
					textBoxTranslateChanged = false;
				}
				catch { }
			}
		}

		private void textBoxTranslate_TextChanged(object sender, EventArgs e)
		{
			textBoxTranslateChanged = true;
		}

		/// <summary>
		/// Handles the KeyPress event of the textBoxTranslate control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
		/// <remarks>OnKeyDown enter is not caught on PDA.</remarks>
		private void textBoxTranslate_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r' && textBoxTranslate.Text.Length > 0)
			{
				CompleteWord();
				listViewTranslate.Focus();
				e.Handled = true;
			}
		}

		private void listViewTranslate_Key(object sender, KeyEventArgs e)
		{
			if (listViewTranslate.Items.Count > 0)
			{
				if (e.KeyCode == Keys.Left)
				{
					textBoxTranslate.Focus();
					e.Handled = true;
				}
				else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Enter)
				{
					ShowTranslation();
					e.Handled = true;
				}
				else if (e.KeyCode == Keys.Up && (listViewTranslate.Items[0].Selected))
				{
					textBoxTranslate.Focus();
					e.Handled = true;
				}
				else if (e.KeyCode == Keys.Down && listViewTranslate.Items[listViewTranslate.Items.Count - 1].Selected)
				{
					textBoxTranslate.Focus();
					e.Handled = true;
				}
			}
			else
			{
				textBoxTranslate.Focus();
			}
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void menuItemDict_Click(object sender, EventArgs e)
		{
			textBoxTranslate.Focus();
			listViewTranslate.Items.Clear();
			string menuName = ((MenuItem)sender).Text;
			for (int i = 0; i < dictionaries.Length; i++)
			{
				if (dictionaries[i].Name == menuName)
				{
					ChooseDictionary(dictionaries[i]);
				}
			}
		}

		private void menuItemTranslate_Click(object sender, EventArgs e)
		{
			if (textBoxTranslate.Focused)
			{
				CompleteWord();
			}
			else
			{
				ShowTranslation();
			}
		}

		private void menuItemSwitch_Click(object sender, EventArgs e)
		{
			if (dictionaries.Length > 0)
			{
				dictionaries.Chosen.Switch();
				WriteName();
				listViewTranslate.Items.Clear();
				textBoxTranslate.Focus();
			}
		}

		private void menuItemClear_Click(object sender, EventArgs e)
		{
			listViewTranslate.Items.Clear();
			textBoxTranslate.Text = string.Empty;
		}

		private void FormMain_Resize(object sender, EventArgs e)
		{
			listViewTranslate.Height = this.ClientSize.Height - textBoxTranslate.Bottom;
		}

		#endregion
	}
}