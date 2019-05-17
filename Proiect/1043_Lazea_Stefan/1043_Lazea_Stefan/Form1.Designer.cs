namespace _1043_Lazea_Stefan
{
    partial class Form1
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.labelDurata = new System.Windows.Forms.Label();
            this.tbDurata = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPret = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.labelMinute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(215, 72);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 0;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(128, 72);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(52, 13);
            this.labelDenumire.TabIndex = 1;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(128, 115);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(27, 13);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gen";
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(215, 112);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(200, 20);
            this.tbGen.TabIndex = 2;
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Location = new System.Drawing.Point(128, 156);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(39, 13);
            this.labelDurata.TabIndex = 5;
            this.labelDurata.Text = "Durata";
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(215, 156);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(163, 20);
            this.tbDurata.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(215, 230);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data lansare";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(128, 193);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 10;
            this.labelPret.Text = "Pret";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(215, 193);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(200, 20);
            this.tbPret.TabIndex = 9;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(392, 159);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(23, 13);
            this.labelMinute.TabIndex = 11;
            this.labelMinute.Text = "min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 361);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDurata);
            this.Controls.Add(this.tbDurata);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.tbDenumire);
            this.Name = "Form1";
            this.Text = "Adaugare film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.TextBox tbDurata;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label labelMinute;
    }
}

