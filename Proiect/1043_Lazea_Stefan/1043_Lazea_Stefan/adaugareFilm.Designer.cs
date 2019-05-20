namespace _1043_Lazea_Stefan
{
    partial class adaugareFilm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugareFilm));
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelDurata = new System.Windows.Forms.Label();
            this.tbDurata = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPret = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.labelMinute = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(322, 111);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(298, 26);
            this.tbDenumire.TabIndex = 0;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(192, 111);
            this.labelDenumire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(78, 20);
            this.labelDenumire.TabIndex = 1;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(192, 177);
            this.labelGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(40, 20);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gen";
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Location = new System.Drawing.Point(192, 240);
            this.labelDurata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(58, 20);
            this.labelDurata.TabIndex = 5;
            this.labelDurata.Text = "Durata";
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(322, 240);
            this.tbDurata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(242, 26);
            this.tbDurata.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(322, 354);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data lansare";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 654);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(426, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(192, 297);
            this.labelPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(38, 20);
            this.labelPret.TabIndex = 10;
            this.labelPret.Text = "Pret";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(322, 297);
            this.tbPret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(298, 26);
            this.tbPret.TabIndex = 9;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(588, 245);
            this.labelMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(34, 20);
            this.labelMinute.TabIndex = 11;
            this.labelMinute.Text = "min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 420);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 209);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acasaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(944, 35);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acasaToolStripMenuItem
            // 
            this.acasaToolStripMenuItem.Name = "acasaToolStripMenuItem";
            this.acasaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.acasaToolStripMenuItem.Text = "Acasa";
            this.acasaToolStripMenuItem.Click += new System.EventHandler(this.acasaToolStripMenuItem_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(322, 174);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(298, 28);
            this.cbCategorie.TabIndex = 15;
            // 
            // adaugareFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 803);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDurata);
            this.Controls.Add(this.tbDurata);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "adaugareFilm";
            this.Text = "Adaugare film";
            this.Load += new System.EventHandler(this.adaugareFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.TextBox tbDurata;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acasaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCategorie;
    }
}

