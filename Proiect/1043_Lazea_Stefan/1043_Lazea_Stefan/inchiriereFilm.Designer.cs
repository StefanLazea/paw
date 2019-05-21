namespace _1043_Lazea_Stefan
{
    partial class inchiriereFilm
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
            if (disposing && (components != null))
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
            this.labelAlegereFilm = new System.Windows.Forms.Label();
            this.labelReturnare = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDetalii = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.rbContExistent = new System.Windows.Forms.RadioButton();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlegereFilm
            // 
            this.labelAlegereFilm.AutoSize = true;
            this.labelAlegereFilm.Location = new System.Drawing.Point(98, 71);
            this.labelAlegereFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlegereFilm.Name = "labelAlegereFilm";
            this.labelAlegereFilm.Size = new System.Drawing.Size(78, 20);
            this.labelAlegereFilm.TabIndex = 0;
            this.labelAlegereFilm.Text = "Alege film";
            // 
            // labelReturnare
            // 
            this.labelReturnare.AutoSize = true;
            this.labelReturnare.Location = new System.Drawing.Point(98, 137);
            this.labelReturnare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturnare.Name = "labelReturnare";
            this.labelReturnare.Size = new System.Drawing.Size(113, 20);
            this.labelReturnare.TabIndex = 1;
            this.labelReturnare.Tag = "Data returnare";
            this.labelReturnare.Text = "Data returnare";
            this.labelReturnare.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(219, 60);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(298, 28);
            this.cbCategorie.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 131);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonDetalii
            // 
            this.buttonDetalii.Location = new System.Drawing.Point(533, 56);
            this.buttonDetalii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetalii.Name = "buttonDetalii";
            this.buttonDetalii.Size = new System.Drawing.Size(112, 35);
            this.buttonDetalii.TabIndex = 4;
            this.buttonDetalii.Text = "Vezi detalii...";
            this.buttonDetalii.UseVisualStyleBackColor = true;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(98, 392);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(51, 20);
            this.labelNume.TabIndex = 5;
            this.labelNume.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(219, 392);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(148, 26);
            this.tbNume.TabIndex = 6;
            // 
            // rbContExistent
            // 
            this.rbContExistent.AutoCheck = false;
            this.rbContExistent.AutoSize = true;
            this.rbContExistent.Location = new System.Drawing.Point(102, 230);
            this.rbContExistent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbContExistent.Name = "rbContExistent";
            this.rbContExistent.Size = new System.Drawing.Size(149, 24);
            this.rbContExistent.TabIndex = 7;
            this.rbContExistent.TabStop = true;
            this.rbContExistent.Text = "Am deja un cont";
            this.rbContExistent.UseVisualStyleBackColor = true;
            this.rbContExistent.CheckedChanged += new System.EventHandler(this.rbContExistent_CheckedChanged);
            this.rbContExistent.Click += new System.EventHandler(this.rbContExistent_Click);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(219, 442);
            this.tbPrenume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(148, 26);
            this.tbPrenume.TabIndex = 9;
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(98, 442);
            this.labelPrenume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(73, 20);
            this.labelPrenume.TabIndex = 8;
            this.labelPrenume.Text = "Prenume";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(497, 293);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(148, 26);
            this.tbAdresa.TabIndex = 11;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(376, 293);
            this.labelAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(60, 20);
            this.labelAdresa.TabIndex = 10;
            this.labelAdresa.Text = "Adresa";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(497, 345);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(148, 26);
            this.tbTelefon.TabIndex = 13;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(376, 345);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(62, 20);
            this.labelTelefon.TabIndex = 12;
            this.labelTelefon.Text = "Telefon";
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(497, 448);
            this.tbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(148, 26);
            this.tbSex.TabIndex = 21;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(376, 448);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(36, 20);
            this.labelSex.TabIndex = 20;
            this.labelSex.Text = "Sex";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(497, 396);
            this.tbVarsta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(148, 26);
            this.tbVarsta.TabIndex = 19;
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(376, 396);
            this.labelVarsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(56, 20);
            this.labelVarsta.TabIndex = 18;
            this.labelVarsta.Text = "Varsta";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(219, 345);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(148, 26);
            this.tbPassword.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(98, 345);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(54, 20);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Parola";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(219, 295);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(148, 26);
            this.tbUsername.TabIndex = 15;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(98, 295);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acasaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 33);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acasaToolStripMenuItem
            // 
            this.acasaToolStripMenuItem.Name = "acasaToolStripMenuItem";
            this.acasaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.acasaToolStripMenuItem.Text = "Acasa";
            this.acasaToolStripMenuItem.Click += new System.EventHandler(this.acasaToolStripMenuItem_Click);
            // 
            // inchiriereFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 577);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.rbContExistent);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.buttonDetalii);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.labelReturnare);
            this.Controls.Add(this.labelAlegereFilm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inchiriereFilm";
            this.Text = "Inchiriaza un film";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlegereFilm;
        private System.Windows.Forms.Label labelReturnare;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonDetalii;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.RadioButton rbContExistent;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acasaToolStripMenuItem;
    }
}