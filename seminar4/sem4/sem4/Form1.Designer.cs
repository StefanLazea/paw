namespace sem4
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
            this.components = new System.ComponentModel.Container();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_varsta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_medie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(87, 30);
            this.tb_cod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(136, 26);
            this.tb_cod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod:\r\n";
            // 
            // tb_sex
            // 
            this.tb_sex.FormattingEnabled = true;
            this.tb_sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.tb_sex.Location = new System.Drawing.Point(87, 95);
            this.tb_sex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(136, 28);
            this.tb_sex.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Varsta:";
            // 
            // tb_varsta
            // 
            this.tb_varsta.Location = new System.Drawing.Point(87, 164);
            this.tb_varsta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_varsta.Name = "tb_varsta";
            this.tb_varsta.Size = new System.Drawing.Size(136, 26);
            this.tb_varsta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nume:";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(87, 225);
            this.tb_nume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(136, 26);
            this.tb_nume.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Medie:";
            // 
            // tb_medie
            // 
            this.tb_medie.Location = new System.Drawing.Point(87, 296);
            this.tb_medie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_medie.Name = "tb_medie";
            this.tb_medie.Size = new System.Drawing.Size(136, 26);
            this.tb_medie.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Note:";
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(87, 361);
            this.tb_note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(136, 26);
            this.tb_note.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adauga ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 516);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Form2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_medie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_varsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cod);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tb_sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_varsta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_medie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

