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
    /// Summary description for form.
    /// </summary>
    public class FormMain : System.Windows.Forms.Form
    {
        private Label label1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        /// <summary>
        /// Main menu for the form.
        /// </summary>
        private System.Windows.Forms.MainMenu mainMenu1;

        public FormMain()
        {
            InitializeComponent();
            SetText();
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
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Konec";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem4);
            this.menuItem2.MenuItems.Add(this.menuItem5);
            this.menuItem2.Text = "Menu";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Hledání podle jména";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Hledání podle data";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nina", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Size = new System.Drawing.Size(176, 276);
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Text = "Svátky";

        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Run(new FormMain());
        }

        private void SetText()
        {
            StringBuilder sb = new StringBuilder();
            DateTime dnes = Svatky.DenDnes;
            sb.Append("Dnes (");
            sb.Append(Svatky.NazevDne(dnes));
            sb.Append(" ");
            sb.Append(dnes.Day);
            sb.Append(".");
            sb.Append(dnes.Month);
            sb.Append(".):\n");
            sb.Append(Svatky.Svatek(dnes));
            DateTime zitra = Svatky.DenZitra;
            sb.Append("\n\nZítra (");
            sb.Append(Svatky.NazevDne(zitra));
            sb.Append(" ");
            sb.Append(zitra.Day);
            sb.Append(".");
            sb.Append(zitra.Month);
            sb.Append(".):\n");
            sb.Append(Svatky.Svatek(zitra));
            DateTime pozitri = Svatky.DenPozitri;
            sb.Append("\n\nPozítøí (");
            sb.Append(Svatky.NazevDne(pozitri));
            sb.Append(" ");
            sb.Append(pozitri.Day);
            sb.Append(".");
            sb.Append(pozitri.Month);
            sb.Append(".):\n");
            sb.Append(Svatky.Svatek(pozitri));
            DateTime popozitri = Svatky.DenPoPozitri;
            sb.Append("\n\nPopozítøí (");
            sb.Append(Svatky.NazevDne(popozitri));
            sb.Append(" ");
            sb.Append(popozitri.Day);
            sb.Append(".");
            sb.Append(popozitri.Month);
            sb.Append(".):\n");
            sb.Append(Svatky.Svatek(popozitri));
            this.label1.Text = sb.ToString();
        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            new FormFindName().Show();
            this.Hide();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            new FormFindDate().Show();
            this.Hide();
        }
    }
}