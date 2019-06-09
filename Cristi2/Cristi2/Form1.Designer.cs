namespace Cristi2
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
            this.labelNrCamera = new System.Windows.Forms.Label();
            this.tbNrCamera = new System.Windows.Forms.TextBox();
            this.tbTipCamera = new System.Windows.Forms.TextBox();
            this.labelTipCamera = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNrCamera
            // 
            this.labelNrCamera.AutoSize = true;
            this.labelNrCamera.Location = new System.Drawing.Point(109, 40);
            this.labelNrCamera.Name = "labelNrCamera";
            this.labelNrCamera.Size = new System.Drawing.Size(76, 13);
            this.labelNrCamera.TabIndex = 0;
            this.labelNrCamera.Text = "Numar camera";
            // 
            // tbNrCamera
            // 
            this.tbNrCamera.Location = new System.Drawing.Point(186, 40);
            this.tbNrCamera.Name = "tbNrCamera";
            this.tbNrCamera.Size = new System.Drawing.Size(100, 20);
            this.tbNrCamera.TabIndex = 1;
            // 
            // tbTipCamera
            // 
            this.tbTipCamera.Location = new System.Drawing.Point(186, 80);
            this.tbTipCamera.Name = "tbTipCamera";
            this.tbTipCamera.Size = new System.Drawing.Size(100, 20);
            this.tbTipCamera.TabIndex = 3;
            // 
            // labelTipCamera
            // 
            this.labelTipCamera.AutoSize = true;
            this.labelTipCamera.Location = new System.Drawing.Point(109, 83);
            this.labelTipCamera.Name = "labelTipCamera";
            this.labelTipCamera.Size = new System.Drawing.Size(60, 13);
            this.labelTipCamera.TabIndex = 2;
            this.labelTipCamera.Text = "Tip camera";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(186, 121);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 20);
            this.tbPret.TabIndex = 5;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(109, 121);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 4;
            this.labelPret.Text = "Pret";
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.Location = new System.Drawing.Point(112, 220);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(174, 38);
            this.buttonAdaugare.TabIndex = 6;
            this.buttonAdaugare.Text = "Adauga";
            this.buttonAdaugare.UseVisualStyleBackColor = true;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.buttonAdaugare);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.tbTipCamera);
            this.Controls.Add(this.labelTipCamera);
            this.Controls.Add(this.tbNrCamera);
            this.Controls.Add(this.labelNrCamera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNrCamera;
        private System.Windows.Forms.TextBox tbNrCamera;
        private System.Windows.Forms.TextBox tbTipCamera;
        private System.Windows.Forms.Label labelTipCamera;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Button buttonAdaugare;
    }
}

