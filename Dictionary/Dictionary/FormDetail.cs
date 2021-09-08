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
		private Form formTranslation;
		private Label labelTranslation;
		private MenuItem menuItemBack;
		private MenuItem menuItemExit;
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
			InitializeComponent2();
			this.formTranslation = formTranslation;
			this.Text = formTranslation.Text;
			this.labelTranslation.Text = translatedItem.Word;
			this.labelNotes.Text = translatedItem.Notes;
			this.labelSpecialNotes.Text = translatedItem.SpecialNotes;
		}

		private void InitializeComponent2()
		{
			if(this.Width != 176)
			{
				PositionAndSizeSetter.DockToLeft(labelTranslation, this);
				PositionAndSizeSetter.DockToLeft(labelNotes, this);
				PositionAndSizeSetter.DockToLeft(labelSpecialNotes, this);
				PositionAndSizeSetter.DockToBottom(labelSpecialNotes, this);
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
			this.labelTranslation = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelNotes = new System.Windows.Forms.Label();
			this.labelSpecialNotes = new System.Windows.Forms.Label();
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
			// labelTranslation
			// 
			this.labelTranslation.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelTranslation.Location = new System.Drawing.Point(0, 0);
			this.labelTranslation.Size = new System.Drawing.Size(176, 50);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.label1.Location = new System.Drawing.Point(0, 50);
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.Text = "Notes:";
			// 
			// labelNotes
			// 
			this.labelNotes.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelNotes.Location = new System.Drawing.Point(0, 67);
			this.labelNotes.Size = new System.Drawing.Size(176, 50);
			// 
			// labelSpecialNotes
			// 
			this.labelSpecialNotes.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
			this.labelSpecialNotes.Location = new System.Drawing.Point(0, 117);
			this.labelSpecialNotes.Size = new System.Drawing.Size(176, 63);
			// 
			// FormDetail
			// 
			this.ClientSize = new System.Drawing.Size(176, 180);
			this.Controls.Add(this.labelSpecialNotes);
			this.Controls.Add(this.labelTranslation);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelNotes);
			this.Menu = this.mainMenu1;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDetail_KeyDown);

		}

		#endregion

		private void menuItemExit_Click(object sender, EventArgs e)
		{

			formTranslation.Close();
			formTranslation.Dispose();
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void menuItemBack_Click(object sender, EventArgs e)
		{
			BackToTranslation();
		}

		private void BackToTranslation()
		{
			formTranslation.Show();
			this.Close();
			this.Dispose();
		}

		private void FormDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == System.Windows.Forms.Keys.Left))
			{
				BackToTranslation();
				e.Handled = true;
			}
		}
	}
}
