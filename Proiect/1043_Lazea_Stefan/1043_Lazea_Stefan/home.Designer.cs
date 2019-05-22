namespace _1043_Lazea_Stefan
{
    partial class home
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
            this.buttonFilme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCategoriePreferata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFilme
            // 
            this.buttonFilme.Location = new System.Drawing.Point(39, 82);
            this.buttonFilme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFilme.Name = "buttonFilme";
            this.buttonFilme.Size = new System.Drawing.Size(328, 62);
            this.buttonFilme.TabIndex = 0;
            this.buttonFilme.Text = "Vezi filmele disponibile";
            this.buttonFilme.UseVisualStyleBackColor = true;
            this.buttonFilme.Click += new System.EventHandler(this.buttonFilme_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vezi ultimele recenzii...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Statistici";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 87);
            this.button3.TabIndex = 3;
            this.button3.Text = "Inchiriaza un film";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCategoriePreferata
            // 
            this.buttonCategoriePreferata.Location = new System.Drawing.Point(41, 466);
            this.buttonCategoriePreferata.Name = "buttonCategoriePreferata";
            this.buttonCategoriePreferata.Size = new System.Drawing.Size(326, 75);
            this.buttonCategoriePreferata.TabIndex = 5;
            this.buttonCategoriePreferata.Text = "Alege categoria preferata";
            this.buttonCategoriePreferata.UseVisualStyleBackColor = true;
            this.buttonCategoriePreferata.Click += new System.EventHandler(this.buttonCategoriePreferata_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 692);
            this.Controls.Add(this.buttonCategoriePreferata);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFilme);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home";
            this.Text = "Pagina principala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFilme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCategoriePreferata;
    }
}