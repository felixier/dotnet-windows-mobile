#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
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
		private MenuItem menuItemSwitch;
		private List<TranslatedItem> translatedItems;
		private int switchCounter;
		/// <summary>
		/// Main menu for the form.
		/// </summary>
		private System.Windows.Forms.MainMenu mainMenu1;

		internal FormTranslation(FormMain formMain, string word, Dictionary dictionary)
		{
			InitializeComponent();
			this.formMain = formMain;
			this.Text = formMain.Text;
			this.dictionary = dictionary;
			TranslateWord(word);
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
			this.menuItemSwitch = new System.Windows.Forms.MenuItem();
			this.labelToTranslate = new System.Windows.Forms.Label();
			this.listViewTranslated = new System.Windows.Forms.ListView();
			this.columnHeaderTranslated = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItemBack);
			this.mainMenu1.MenuItems.Add(this.menuItemSwitch);
			// 
			// menuItemBack
			// 
			this.menuItemBack.Text = global::Dictionary.DictionaryStrings.Back;
			this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click);
			// 
			// menuItemSwitch
			// 
			this.menuItemSwitch.Text = global::Dictionary.DictionaryStrings.Switch;
			this.menuItemSwitch.Click += new System.EventHandler(this.menuItemSwitch_Click);
			// 
			// labelToTranslate
			// 
			this.labelToTranslate.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelToTranslate.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelToTranslate.Location = new System.Drawing.Point(0, 0);
			this.labelToTranslate.Name = "labelToTranslate";
			this.labelToTranslate.Size = new System.Drawing.Size(240, 69);
			// 
			// listViewTranslated
			// 
			this.listViewTranslated.Columns.Add(this.columnHeaderTranslated);
			this.listViewTranslated.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listViewTranslated.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.listViewTranslated.FullRowSelect = true;
			this.listViewTranslated.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTranslated.Location = new System.Drawing.Point(0, 72);
			this.listViewTranslated.Name = "listViewTranslated";
			this.listViewTranslated.Size = new System.Drawing.Size(240, 194);
			this.listViewTranslated.TabIndex = 1;
			this.listViewTranslated.View = System.Windows.Forms.View.Details;
			this.listViewTranslated.GotFocus += new System.EventHandler(this.listViewTranslated_GotFocus);
			this.listViewTranslated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTranslated_KeyDown);
			// 
			// columnHeaderTranslated
			// 
			this.columnHeaderTranslated.Text = "ColumnHeader";
			this.columnHeaderTranslated.Width = 230;
			// 
			// FormTranslation
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(240, 266);
			this.Controls.Add(this.labelToTranslate);
			this.Controls.Add(this.listViewTranslated);
			this.Menu = this.mainMenu1;
			this.Name = "FormTranslation";
			this.Resize += new System.EventHandler(this.FormTranslation_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		#region private methods

		private void BackToMain()
		{
			// Dictionary has to be switched because it would be different than in the main form.
			if (switchCounter % 2 == 1)
			{
				dictionary.Switch();
			}

			formMain.Show();
			this.Close();
			this.Dispose();
		}

		/// <summary>
		/// Translates the word.
		/// </summary>
		/// <param name="word">The word.</param>
		private void TranslateWord(string word)
		{
			labelToTranslate.Text = word;
			listViewTranslated.Items.Clear();

			translatedItems = dictionary.TranslateWord(labelToTranslate.Text);
			foreach (TranslatedItem item in translatedItems)
			{
				listViewTranslated.Items.Add(new ListViewItem(item.Word));
			}

			listViewTranslated.Items[0].Selected = true;
			listViewTranslated.Items[0].Focused = true;
			columnHeaderTranslated.Width = listViewTranslated.ClientSize.Width;
		}

		/// <summary>
		/// Switches currently selected word.
		/// </summary>
		internal void Switch()
		{
			dictionary.Switch();
			switchCounter++;
			TranslateWord(listViewTranslated.FocusedItem.Text);
		}

		#endregion

		#region event handlers

		private void menuItemBack_Click(object sender, EventArgs e)
		{
			BackToMain();
		}

		private void listViewTranslated_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				BackToMain();
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Enter)
			{
				new FormDetail(this, translatedItems[listViewTranslated.FocusedItem.Index]).Show();
				this.Hide();
				e.Handled = true;
			}
		}

		private void menuItemSwitch_Click(object sender, EventArgs e)
		{
			Switch();
		}

		private void listViewTranslated_GotFocus(object sender, EventArgs e)
		{
			columnHeaderTranslated.Width = listViewTranslated.ClientSize.Width;
		}

		private void FormTranslation_Resize(object sender, EventArgs e)
		{
			listViewTranslated.Height = this.ClientSize.Height - labelToTranslate.Bottom;
		}

		#endregion
	}
}
