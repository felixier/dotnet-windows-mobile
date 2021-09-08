#region Using directives

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Text;

#endregion

namespace Svatky
{
    /// <summary>
    /// Summary description for Form3.
    /// </summary>
    public class FormFindDate : System.Windows.Forms.Form
    {
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        /// <summary>
        /// Main menu for the form.
        /// </summary>
        private System.Windows.Forms.MainMenu mainMenu1;

        public FormFindDate()
        {
            InitializeComponent();
            SetTextbox();
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Zpìt";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "OK";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.Text = "Datum:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Size = new System.Drawing.Size(170, 24);
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Size = new System.Drawing.Size(170, 118);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Menu = this.mainMenu1;
            this.Text = "Svátky";

        }

        #endregion

        private void SetTextbox()
        {
            DateTime dnes = DateTime.Today;
            StringBuilder sb = new StringBuilder();
            sb.Append(dnes.Day);
            sb.Append(".");
            sb.Append(dnes.Month);
            sb.Append(".");
            textBox1.Text = sb.ToString();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            string datum = textBox1.Text;
            char tecka = '.';
            int i1 = datum.IndexOf(tecka);
            int i2 = datum.LastIndexOf(tecka);
            try
            {
                int den = int.Parse(datum.Substring(0, i1));
                int mesic = int.Parse(datum.Substring(i1 + 1, i2 - i1 - 1));
                label2.Text = Svatky.HledaniPodleData(den, mesic);
                if(label2.Text.Length == 0)
                {
                    label2.Text = "Chybnì zadané datum!";
                }
            }
            catch(Exception)
            {
                label2.Text = "Chybnì zadané datum!";
            }
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            Keyboard.SetType(Keyboard.Modes.Numbers);
        }
    }
}
