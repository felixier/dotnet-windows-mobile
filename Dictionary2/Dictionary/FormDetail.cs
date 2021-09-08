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
	/// Summary description for FormDetail.
	/// </summary>
	public class FormDetail : System.Windows.Forms.Form
	{
		private FormTranslation formTranslation;
		private Label labelTranslation;
		private MenuItem menuItemBack;
		private MenuItem menuItemSwitch;
		private Label label1;
		private Label labelNotes;
		private Label labelSpecialNotes;
		/// <summary>
		/// Main menu for the form.
		/// </summary>
		private System.Windows.Forms.MainMenu mainMenu1;

		internal FormDetail(FormTranslation formTranslation, TranslatedItem translatedItem)
		{
			InitializeComponent();
			this.formTranslation = formTranslation;
			this.Text = formTranslation.Text;
			this.labelTranslation.Text = translatedItem.Word;
			this.labelNotes.Text = translatedItem.Notes;
			this.labelSpecialNotes.Text = translatedItem.SpecialNotes;
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
			this.labelTranslation = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelNotes = new System.Windows.Forms.Label();
			this.labelSpecialNotes = new System.Windows.Forms.Label();
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
			// labelTranslation
			// 
			this.labelTranslation.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTranslation.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelTranslation.Location = new System.Drawing.Point(0, 0);
			this.labelTranslation.Name = "labelTranslation";
			this.labelTranslation.Size = new System.Drawing.Size(240, 89);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.label1.Location = new System.Drawing.Point(0, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 29);
			this.label1.Text = "Notes:";
			// 
			// labelNotes
			// 
			this.labelNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelNotes.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelNotes.Location = new System.Drawing.Point(0, 128);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(240, 68);
			// 
			// labelSpecialNotes
			// 
			this.labelSpecialNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelSpecialNotes.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelSpecialNotes.Location = new System.Drawing.Point(0, 196);
			this.labelSpecialNotes.Name = "labelSpecialNotes";
			this.labelSpecialNotes.Size = new System.Drawing.Size(240, 70);
			// 
			// FormDetail
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(240, 266);
			this.Controls.Add(this.labelNotes);
			this.Controls.Add(this.labelSpecialNotes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTranslation);
			this.Menu = this.mainMenu1;
			this.Name = "FormDetail";
			this.Resize += new System.EventHandler(this.FormDetail_Resize);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDetail_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		#region private methods

		private void BackToTranslation()
		{
			formTranslation.Show();
			this.Close();
			this.Dispose();
		}

		/// <summary>
		/// Switches currently selected word.
		/// </summary>
		private void Switch()
		{
			formTranslation.Switch();
			BackToTranslation();
		}

		#endregion

		#region event handlers

		private void menuItemSwitch_Click(object sender, EventArgs e)
		{
			Switch();
		}

		private void menuItemBack_Click(object sender, EventArgs e)
		{
			BackToTranslation();
		}

		private void FormDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
			{
				BackToTranslation();
				e.Handled = true;
			}
		}

		private void FormDetail_Resize(object sender, EventArgs e)
		{
			labelNotes.Height = labelSpecialNotes.Top - label1.Bottom;
		}

		#endregion		
	}
}