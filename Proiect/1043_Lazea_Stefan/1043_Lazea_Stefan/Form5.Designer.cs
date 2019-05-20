namespace _1043_Lazea_Stefan
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDetalii = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbContExistent = new System.Windows.Forms.RadioButton();
            this.buttonContNou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Data returnare";
            this.label2.Text = "Data returnare";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(250, 66);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(180, 28);
            this.cbCategorie.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 137);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonDetalii
            // 
            this.buttonDetalii.Location = new System.Drawing.Point(480, 63);
            this.buttonDetalii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetalii.Name = "buttonDetalii";
            this.buttonDetalii.Size = new System.Drawing.Size(112, 35);
            this.buttonDetalii.TabIndex = 4;
            this.buttonDetalii.Text = "Vezi detalii...";
            this.buttonDetalii.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 6;
            // 
            // rbContExistent
            // 
            this.rbContExistent.AutoSize = true;
            this.rbContExistent.Location = new System.Drawing.Point(102, 234);
            this.rbContExistent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbContExistent.Name = "rbContExistent";
            this.rbContExistent.Size = new System.Drawing.Size(149, 24);
            this.rbContExistent.TabIndex = 7;
            this.rbContExistent.TabStop = true;
            this.rbContExistent.Text = "Am deja un cont";
            this.rbContExistent.UseVisualStyleBackColor = true;
            // 
            // buttonContNou
            // 
            this.buttonContNou.Location = new System.Drawing.Point(480, 234);
            this.buttonContNou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContNou.Name = "buttonContNou";
            this.buttonContNou.Size = new System.Drawing.Size(112, 35);
            this.buttonContNou.TabIndex = 8;
            this.buttonContNou.Text = "Cont nou...";
            this.buttonContNou.UseVisualStyleBackColor = true;
            this.buttonContNou.Click += new System.EventHandler(this.buttonContNou_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonContNou);
            this.Controls.Add(this.rbContExistent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDetalii);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Inchiriaza un film";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonDetalii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbContExistent;
        private System.Windows.Forms.Button buttonContNou;
    }
}