namespace _1043_Lazea_Stefan
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
            this.buttonFilme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFilme
            // 
            this.buttonFilme.Location = new System.Drawing.Point(29, 131);
            this.buttonFilme.Name = "buttonFilme";
            this.buttonFilme.Size = new System.Drawing.Size(219, 40);
            this.buttonFilme.TabIndex = 0;
            this.buttonFilme.Text = "Vezi filmele disponibile";
            this.buttonFilme.UseVisualStyleBackColor = true;
            this.buttonFilme.Click += new System.EventHandler(this.buttonFilme_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilme);
            this.Name = "Form2";
            this.Text = "Pagina principala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFilme;
    }
}