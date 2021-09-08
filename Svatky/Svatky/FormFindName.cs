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
    /// Summary description for Form2.
    /// </summary>
    public class FormFindName : System.Windows.Forms.Form
    {
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        /// <summary>
        /// Main menu for the form.
        /// </summary>
        private System.Windows.Forms.MainMenu mainMenu1;

        public FormFindName()
        {
            InitializeComponent();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Size = new System.Drawing.Size(170, 24);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.Text = "Jméno nebo èást jména:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nina", 11F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Size = new System.Drawing.Size(170, 118);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Menu = this.mainMenu1;
            this.Text = "Svátky";

        }

        #endregion

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            string nalezeneJmeno;
            DateTime nalezeneDatum;
            if(textBox1.Text.Length > 0)
            {
                if(Svatky.HledaniPodleJmena(textBox1.Text, out nalezeneJmeno, out nalezeneDatum))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(nalezeneJmeno);
                    sb.Append(":\n");
                    sb.Append(nalezeneDatum.Day);
                    sb.Append(". ");
                    sb.Append(Svatky.NazevMesice(nalezeneDatum));
                    sb.Append(" (letos ");
                    sb.Append(Svatky.NazevDne(nalezeneDatum));
                    sb.Append(")");
                    label2.Text = sb.ToString();
                }
                else
                {
                    label2.Text = "Jméno nebylo nalezeno.";
                }
            }
            else
            {
                label2.Text = "Není zadáno jméno.";
            }
        }
    }
}
