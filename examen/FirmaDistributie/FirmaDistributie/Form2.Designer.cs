namespace FirmaDistributie
{
    partial class Form2
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
            this.label1I = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnitati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFurnizori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1I
            // 
            this.label1I.AutoSize = true;
            this.label1I.Location = new System.Drawing.Point(114, 80);
            this.label1I.Name = "label1I";
            this.label1I.Size = new System.Drawing.Size(16, 13);
            this.label1I.TabIndex = 0;
            this.label1I.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(193, 80);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(193, 126);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(121, 20);
            this.textBoxNume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // textBoxUnitati
            // 
            this.textBoxUnitati.Location = new System.Drawing.Point(193, 172);
            this.textBoxUnitati.Name = "textBoxUnitati";
            this.textBoxUnitati.Size = new System.Drawing.Size(121, 20);
            this.textBoxUnitati.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unitati";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(193, 220);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(121, 20);
            this.textBoxPret.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pret";
            // 
            // comboBoxFurnizori
            // 
            this.comboBoxFurnizori.FormattingEnabled = true;
            this.comboBoxFurnizori.Location = new System.Drawing.Point(193, 267);
            this.comboBoxFurnizori.Name = "comboBoxFurnizori";
            this.comboBoxFurnizori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFurnizori.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Furnizori";
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(193, 320);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(75, 23);
            this.buttonEditare.TabIndex = 10;
            this.buttonEditare.Text = "Adaugare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFurnizori);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUnitati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1I);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1I;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnitati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFurnizori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditare;
    }
}