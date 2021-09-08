namespace DictionaryConverter
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.firstLang = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.secondLang = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dictFile = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.browseButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dictFileOut = new System.Windows.Forms.Label();
			this.convertButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First language name:";
			// 
			// firstLang
			// 
			this.firstLang.Location = new System.Drawing.Point(12, 81);
			this.firstLang.Name = "firstLang";
			this.firstLang.Size = new System.Drawing.Size(445, 20);
			this.firstLang.TabIndex = 3;
			this.firstLang.TextChanged += new System.EventHandler(this.languageNameChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Second language name:";
			// 
			// secondLang
			// 
			this.secondLang.Location = new System.Drawing.Point(12, 136);
			this.secondLang.Name = "secondLang";
			this.secondLang.Size = new System.Drawing.Size(445, 20);
			this.secondLang.TabIndex = 4;
			this.secondLang.TextChanged += new System.EventHandler(this.languageNameChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dictionary file (text):";
			// 
			// dictFile
			// 
			this.dictFile.Location = new System.Drawing.Point(12, 26);
			this.dictFile.Name = "dictFile";
			this.dictFile.Size = new System.Drawing.Size(371, 20);
			this.dictFile.TabIndex = 1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "";
			this.openFileDialog1.Filter = "Txt File (*.txt)|*.txt|All Files (*.*)|*.*";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(389, 24);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(68, 23);
			this.browseButton.TabIndex = 2;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browse_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(185, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Converted dictionary will be saved as:";
			// 
			// dictFileOut
			// 
			this.dictFileOut.AutoSize = true;
			this.dictFileOut.Location = new System.Drawing.Point(209, 182);
			this.dictFileOut.Name = "dictFileOut";
			this.dictFileOut.Size = new System.Drawing.Size(167, 13);
			this.dictFileOut.TabIndex = 8;
			this.dictFileOut.Text = "!Names of languages must be set!";
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(12, 231);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(445, 23);
			this.convertButton.TabIndex = 5;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "(Same dir. as textual dictionary file)";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 266);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.dictFileOut);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.dictFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.secondLang);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.firstLang);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = this.Size;
			this.Name = "FormMain";
			this.Text = "Dictionary Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox firstLang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox secondLang;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox dictFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label dictFileOut;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Label label5;
	}
}

