#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

#endregion

namespace Dictionary
{
	/// <summary>
	/// Summary description for FormTranslation.
	/// </summary>
	public class FormTranslation : System.Windows.Forms.Form
	{
		private Dictionary dictionary;
		private MenuItem menuItemBack;
		private FormMain formMain;
		private Label labelToTranslate;
		private ListView listViewTranslated;
		private ColumnHeader columnHeaderTranslated;
		private MenuItem menuItemExit;
		private ArrayList translatedItems;
		/// <summary>
		/// Main menu for the form.
		/// </summary>
		private System.Windows.Forms.MainMenu mainMenu1;

		internal FormTranslation(FormMain formMain, string word, Dictionary dictionary)
		{
			InitializeComponent();
			InitializeComponent2();
			this.formMain = formMain;
			this.Text = formMain.Text;
			labelToTranslate.Text = word;
			this.dictionary = dictionary;
			TranslateWord();
			listViewTranslated.Items[0].Selected = true;
			listViewTranslated.Items[0].Focused = true;
		}

		private void InitializeComponent2()
		{
			if(this.Width != 176)
			{
				PositionAndSizeSetter.DockToLeft(labelToTranslate, this);
				PositionAndSizeSetter.DockToLeft(listViewTranslated, this);
				PositionAndSizeSetter.DockToBottom(listViewTranslated, this);
				columnHeaderTranslated.Width = PositionAndSizeSetter.CountSizeInRatio(columnHeaderTranslated.Width, this.ClientSize.Width, this.Width) - 10;
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
			this.menuItemBack = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.labelToTranslate = new System.Windows.Forms.Label();
			this.listViewTranslated = new System.Windows.Forms.ListView();
			this.columnHeaderTranslated = new System.Windows.Forms.ColumnHeader();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItemBack);
			this.mainMenu1.MenuItems.Add(this.menuItemExit);
			// 
			// menuItemBack
			// 
			this.menuItemBack.Text = "Back";
			this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// labelToTranslate
			// 
			this.labelToTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelToTranslate.Location = new System.Drawing.Point(0, 0);
			this.labelToTranslate.Size = new System.Drawing.Size(176, 50);
			// 
			// listViewTranslated
			// 
			this.listViewTranslated.Columns.Add(this.columnHeaderTranslated);
			this.listViewTranslated.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.listViewTranslated.FullRowSelect = true;
			this.listViewTranslated.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTranslated.Location = new System.Drawing.Point(0, 51);
			this.listViewTranslated.Size = new System.Drawing.Size(176, 130);
			this.listViewTranslated.View = System.Windows.Forms.View.Details;
			this.listViewTranslated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTranslated_KeyDown);
			// 
			// columnHeaderTranslated
			// 
			this.columnHeaderTranslated.Text = "ColumnHeader";
			this.columnHeaderTranslated.Width = 168;
			// 
			// FormTranslation
			// 
			this.ClientSize = new System.Drawing.Size(176, 180);
			this.Controls.Add(this.labelToTranslate);
			this.Controls.Add(this.listViewTranslated);
			this.Menu = this.mainMenu1;

		}

		#endregion

		private void menuItemBack_Click(object sender, EventArgs e)
		{
			BackToMain();
		}

		private void BackToMain()
		{
			formMain.Show();
			this.Close();
			this.Dispose();
		}

		private void listViewTranslated_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
			{
				BackToMain();
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.Right || e.KeyCode == Keys.Enter)
			{
				new FormDetail(this, (TranslatedItem)translatedItems[listViewTranslated.FocusedItem.Index]).Show();
				this.Hide();
				e.Handled = true;
			}
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			formMain.Close();
			formMain.Dispose();
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void TranslateWord()
		{
			translatedItems = dictionary.TranslateWord(labelToTranslate.Text);
			foreach(TranslatedItem item in translatedItems)
			{
				listViewTranslated.Items.Add(new ListViewItem(item.Word));
			}
		}
	}
}
