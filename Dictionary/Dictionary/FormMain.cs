#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;
using Finisar.SQLite;

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
		private MenuItem menuItemSwitch;
		/// <summary>
		/// Main menu for the form.
		/// </summary>
		private System.Windows.Forms.MainMenu mainMenu1;

		public FormMain()
		{
			InitializeComponent();
			InitializeComponent2();
			InitializeMenu();
#if DEBUG
			Fill();
#endif
		}

		private void Fill()
		{
			textBoxTranslate.Text = "fajsdlfjawshfq3h4tjhk34lhkjsdhflkjsdfljahsf";
			for(int i = 0; i < 15; i++)
			{
				listViewTranslate.Items.Add(new ListViewItem("fajhsdjfahlsdjhfa567586648lsjdhflasjhg3467"));
			}
			listViewTranslate.Focus();
		}

		private void InitializeComponent2()
		{
			if(this.Width != 176)
			{
				PositionAndSizeSetter.DockToLeft(textBoxTranslate, this);
				PositionAndSizeSetter.DockToLeft(listViewTranslate, this);
				PositionAndSizeSetter.DockToBottom(listViewTranslate, this);
				this.columnHeaderTranslate.Width = PositionAndSizeSetter.CountSizeInRatio(this.columnHeaderTranslate.Width, this.ClientSize.Width, this.Width) - 10;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
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
			this.menuItemSwitch = new System.Windows.Forms.MenuItem();
			this.textBoxTranslate = new System.Windows.Forms.TextBox();
			this.listViewTranslate = new System.Windows.Forms.ListView();
			this.columnHeaderTranslate = new System.Windows.Forms.ColumnHeader();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItemTranslate);
			this.mainMenu1.MenuItems.Add(this.menuItemMenu);
			// 
			// menuItemTranslate
			// 
			this.menuItemTranslate.Text = "Translate";
			this.menuItemTranslate.Click += new System.EventHandler(this.menuItemTranslate_Click);
			// 
			// menuItemMenu
			// 
			this.menuItemMenu.Text = "Menu";
			// 
			// menuItemLine
			// 
			this.menuItemLine.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemSwitch
			// 
			this.menuItemSwitch.Text = "Switch";
			this.menuItemSwitch.Click += new System.EventHandler(this.menuItemSwitch_Click);
			// 
			// textBoxTranslate
			// 
			this.textBoxTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.textBoxTranslate.Location = new System.Drawing.Point(0, 0);
			this.textBoxTranslate.Size = new System.Drawing.Size(176, 23);
			this.textBoxTranslate.TextChanged += new System.EventHandler(this.textBoxTranslate_TextChanged);
			this.textBoxTranslate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTranslate_Key);
			// 
			// listViewTranslate
			// 
			this.listViewTranslate.Columns.Add(this.columnHeaderTranslate);
			this.listViewTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.listViewTranslate.FullRowSelect = true;
			this.listViewTranslate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTranslate.Location = new System.Drawing.Point(0, 23);
			this.listViewTranslate.Size = new System.Drawing.Size(176, 158);
			this.listViewTranslate.View = System.Windows.Forms.View.Details;
			this.listViewTranslate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTranslate_Key);
			this.listViewTranslate.GotFocus += new System.EventHandler(this.listViewTranslate_GotFocus);
			// 
			// columnHeaderTranslate
			// 
			this.columnHeaderTranslate.Text = "ColumnHeader";
			this.columnHeaderTranslate.Width = 168;
			// 
			// FormMain
			// 
			this.ClientSize = new System.Drawing.Size(176, 180);
			this.Controls.Add(this.listViewTranslate);
			this.Controls.Add(this.textBoxTranslate);
			this.Menu = this.mainMenu1;
			this.Text = "Dictionary";

		}

		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Run(new FormMain());
		}

		private void listViewTranslate_GotFocus(object sender, EventArgs e)
		{
			if(textBoxTranslateChanged)
			{
				try
				{
					listViewTranslate.Items[0].Selected = true;
					listViewTranslate.Items[0].Focused = true;
					textBoxTranslateChanged = false;
				}
				catch { }
			}
		}

		private void textBoxTranslate_TextChanged(object sender, EventArgs e)
		{
			textBoxTranslateChanged = true;
		}

		private void textBoxTranslate_Key(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && textBoxTranslate.Text.Length > 0)
			{
				CompleteWord();
				listViewTranslate.Focus();
				e.Handled = true;
			}
		}

		private void listViewTranslate_Key(object sender, KeyEventArgs e)
		{
			if(listViewTranslate.Items.Count > 0)
			{
				if(e.KeyCode == Keys.Left)
				{
					textBoxTranslate.Focus();
					e.Handled = true;
				}
				else if(e.KeyCode == Keys.Right || e.KeyCode == Keys.Enter)
				{
					ShowTranslation();
					e.Handled = true;
				}
				else if(e.KeyCode == Keys.Up && (listViewTranslate.Items[0].Selected))
				{
					textBoxTranslate.Focus();
					e.Handled = true;
				}
				else if(e.KeyCode == Keys.Down && listViewTranslate.Items[listViewTranslate.Items.Count - 1].Selected)
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

		private void ShowTranslation()
		{
			if(listViewTranslate.FocusedItem == null)
			{
				textBoxTranslate.Focus();
			}
			else
			{
				new FormTranslation(this, listViewTranslate.FocusedItem.Text, dictionaries.Chosen).Show();
				this.Hide();
			}
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void InitializeMenu()
		{
			for(int i = 0; i < dictionaries.Length; i++)
			{
				MenuItem m = new MenuItem();
				m.Text = dictionaries[i].Name;
				m.Click += new EventHandler(this.menuItemDict_Click);
				menuItemMenu.MenuItems.Add(m);
			}
			if(dictionaries.Length > 0)
			{
				menuItemMenu.MenuItems.Add(menuItemLine);
				menuItemMenu.MenuItems.Add(menuItemSwitch);
				menuItemMenu.MenuItems.Add(menuItemExit);
				ChooseDictionary(dictionaries[0]);
				textBoxTranslate.Focus();
			}
			else
			{
#if !DEBUG
				textBoxTranslate.Text = "No dictionary";
				textBoxTranslate.Enabled = false;
				listViewTranslate.Enabled = false;
#endif
			}
		}

		private void ChooseDictionary(Dictionary dict)
		{
			if(dictionaries.Chosen != null)
			{
				dictionaries.Chosen.Close();
			}
			dictionaries.Chosen = dict;
			WriteName();
		}

		private void WriteName()
		{
			this.Text = "Dictionary " + dictionaries.Chosen.ActualName;
		}

		private void menuItemDict_Click(object sender, EventArgs e)
		{
			textBoxTranslate.Focus();
			listViewTranslate.Items.Clear();
			string menuName = ((MenuItem)sender).Text;
			for(int i = 0; i < dictionaries.Length; i++)
			{
				if(dictionaries[i].Name == menuName)
				{
					ChooseDictionary(dictionaries[i]);
				}
			}
		}

		private void CompleteWord()
		{
			if(textBoxTranslate.Text.Length > 0)
			{
				listViewTranslate.Items.Clear();
				ArrayList completedWord = dictionaries.Chosen.CompleteWord(textBoxTranslate.Text);
				foreach(string word in completedWord)
				{
					listViewTranslate.Items.Add(new ListViewItem(word));
				}
				listViewTranslate.Focus();
			}
		}

		private void menuItemTranslate_Click(object sender, EventArgs e)
		{
			if(textBoxTranslate.Focused)
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
			if(dictionaries.Length > 0)
			{
				listViewTranslate.Items.Clear();
				dictionaries.Chosen.Switch();
				WriteName();
				listViewTranslate.Items.Clear();
				textBoxTranslate.Focus();
			}
		}
	}
}