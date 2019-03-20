namespace WindowsFormsApp1
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
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label_cod = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.label_varsta = new System.Windows.Forms.Label();
            this.tb_varsta = new System.Windows.Forms.TextBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.cb_nume = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.label_medie = new System.Windows.Forms.Label();
            this.tb_medie = new System.Windows.Forms.TextBox();
            this.b_adauga = new System.Windows.Forms.Button();
            this.button_lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(332, 66);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(121, 20);
            this.tb_cod.TabIndex = 0;
            // 
            // label_cod
            // 
            this.label_cod.AutoSize = true;
            this.label_cod.Location = new System.Drawing.Point(267, 69);
            this.label_cod.Name = "label_cod";
            this.label_cod.Size = new System.Drawing.Size(26, 13);
            this.label_cod.TabIndex = 1;
            this.label_cod.Text = "Cod";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(268, 92);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(25, 13);
            this.label_sex.TabIndex = 2;
            this.label_sex.Text = "Sex";
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sex.Location = new System.Drawing.Point(332, 92);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(121, 21);
            this.cb_sex.TabIndex = 3;
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_varsta.Location = new System.Drawing.Point(256, 122);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(37, 13);
            this.label_varsta.TabIndex = 5;
            this.label_varsta.Text = "Varsta";
            // 
            // tb_varsta
            // 
            this.tb_varsta.Location = new System.Drawing.Point(332, 119);
            this.tb_varsta.Name = "tb_varsta";
            this.tb_varsta.Size = new System.Drawing.Size(121, 20);
            this.tb_varsta.TabIndex = 4;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_nume.Location = new System.Drawing.Point(256, 148);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(35, 13);
            this.label_nume.TabIndex = 9;
            this.label_nume.Text = "Nume";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(332, 145);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(121, 20);
            this.tb_nume.TabIndex = 8;
            // 
            // cb_nume
            // 
            this.cb_nume.AutoSize = true;
            this.cb_nume.Location = new System.Drawing.Point(261, 176);
            this.cb_nume.Name = "cb_nume";
            this.cb_nume.Size = new System.Drawing.Size(30, 13);
            this.cb_nume.TabIndex = 10;
            this.cb_nume.Text = "Note";
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(332, 176);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(121, 20);
            this.tb_note.TabIndex = 11;
            // 
            // label_medie
            // 
            this.label_medie.AutoSize = true;
            this.label_medie.Location = new System.Drawing.Point(257, 205);
            this.label_medie.Name = "label_medie";
            this.label_medie.Size = new System.Drawing.Size(36, 13);
            this.label_medie.TabIndex = 12;
            this.label_medie.Text = "Medie";
            // 
            // tb_medie
            // 
            this.tb_medie.Location = new System.Drawing.Point(332, 205);
            this.tb_medie.Name = "tb_medie";
            this.tb_medie.Size = new System.Drawing.Size(121, 20);
            this.tb_medie.TabIndex = 13;
            // 
            // b_adauga
            // 
            this.b_adauga.Location = new System.Drawing.Point(270, 256);
            this.b_adauga.Name = "b_adauga";
            this.b_adauga.Size = new System.Drawing.Size(75, 23);
            this.b_adauga.TabIndex = 14;
            this.b_adauga.Text = "Adauga";
            this.b_adauga.UseVisualStyleBackColor = true;
            this.b_adauga.Click += new System.EventHandler(this.b_adauga_Click);
            // 
            // button_lista
            // 
            this.button_lista.Location = new System.Drawing.Point(386, 256);
            this.button_lista.Name = "button_lista";
            this.button_lista.Size = new System.Drawing.Size(67, 23);
            this.button_lista.TabIndex = 16;
            this.button_lista.Text = "Lista Studenti";
            this.button_lista.UseVisualStyleBackColor = true;
            this.button_lista.Click += new System.EventHandler(this.button_lista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_lista);
            this.Controls.Add(this.b_adauga);
            this.Controls.Add(this.tb_medie);
            this.Controls.Add(this.label_medie);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.cb_nume);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label_varsta);
            this.Controls.Add(this.tb_varsta);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.label_cod);
            this.Controls.Add(this.tb_cod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label_cod;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Label label_varsta;
        private System.Windows.Forms.TextBox tb_varsta;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.Label cb_nume;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label label_medie;
        private System.Windows.Forms.TextBox tb_medie;
        private System.Windows.Forms.Button b_adauga;
        private System.Windows.Forms.Button button_lista;
    }
}

