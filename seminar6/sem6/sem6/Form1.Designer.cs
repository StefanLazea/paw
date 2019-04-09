namespace sem6
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
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_XAU = new System.Windows.Forms.TextBox();
            this.tb_GBP = new System.Windows.Forms.TextBox();
            this.tb_USD = new System.Windows.Forms.TextBox();
            this.tb_Eur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(87, 35);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(100, 22);
            this.tb_data.TabIndex = 0;
            // 
            // tb_XAU
            // 
            this.tb_XAU.Location = new System.Drawing.Point(87, 256);
            this.tb_XAU.Name = "tb_XAU";
            this.tb_XAU.Size = new System.Drawing.Size(100, 22);
            this.tb_XAU.TabIndex = 1;
            // 
            // tb_GBP
            // 
            this.tb_GBP.Location = new System.Drawing.Point(87, 202);
            this.tb_GBP.Name = "tb_GBP";
            this.tb_GBP.Size = new System.Drawing.Size(100, 22);
            this.tb_GBP.TabIndex = 2;
            // 
            // tb_USD
            // 
            this.tb_USD.Location = new System.Drawing.Point(87, 143);
            this.tb_USD.Name = "tb_USD";
            this.tb_USD.Size = new System.Drawing.Size(100, 22);
            this.tb_USD.TabIndex = 3;
            // 
            // tb_Eur
            // 
            this.tb_Eur.Location = new System.Drawing.Point(87, 88);
            this.tb_Eur.Name = "tb_Eur";
            this.tb_Eur.Size = new System.Drawing.Size(100, 22);
            this.tb_Eur.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "GBP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "XAU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parsare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Eur);
            this.Controls.Add(this.tb_USD);
            this.Controls.Add(this.tb_GBP);
            this.Controls.Add(this.tb_XAU);
            this.Controls.Add(this.tb_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_XAU;
        private System.Windows.Forms.TextBox tb_GBP;
        private System.Windows.Forms.TextBox tb_USD;
        private System.Windows.Forms.TextBox tb_Eur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

