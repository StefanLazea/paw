namespace Cristi2
{
    partial class Form3
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
            this.buttonEditare = new System.Windows.Forms.Button();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.tbTipCamera = new System.Windows.Forms.TextBox();
            this.labelTipCamera = new System.Windows.Forms.Label();
            this.tbNrCamera = new System.Windows.Forms.TextBox();
            this.labelNrCamera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(190, 245);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(174, 38);
            this.buttonEditare.TabIndex = 13;
            this.buttonEditare.Text = "Edit";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(264, 146);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 20);
            this.tbPret.TabIndex = 12;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(187, 146);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 11;
            this.labelPret.Text = "Pret";
            // 
            // tbTipCamera
            // 
            this.tbTipCamera.Location = new System.Drawing.Point(264, 105);
            this.tbTipCamera.Name = "tbTipCamera";
            this.tbTipCamera.Size = new System.Drawing.Size(100, 20);
            this.tbTipCamera.TabIndex = 10;
            // 
            // labelTipCamera
            // 
            this.labelTipCamera.AutoSize = true;
            this.labelTipCamera.Location = new System.Drawing.Point(187, 108);
            this.labelTipCamera.Name = "labelTipCamera";
            this.labelTipCamera.Size = new System.Drawing.Size(60, 13);
            this.labelTipCamera.TabIndex = 9;
            this.labelTipCamera.Text = "Tip camera";
            // 
            // tbNrCamera
            // 
            this.tbNrCamera.Location = new System.Drawing.Point(264, 65);
            this.tbNrCamera.Name = "tbNrCamera";
            this.tbNrCamera.Size = new System.Drawing.Size(100, 20);
            this.tbNrCamera.TabIndex = 8;
            // 
            // labelNrCamera
            // 
            this.labelNrCamera.AutoSize = true;
            this.labelNrCamera.Location = new System.Drawing.Point(187, 65);
            this.labelNrCamera.Name = "labelNrCamera";
            this.labelNrCamera.Size = new System.Drawing.Size(76, 13);
            this.labelNrCamera.TabIndex = 7;
            this.labelNrCamera.Text = "Numar camera";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 324);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.tbTipCamera);
            this.Controls.Add(this.labelTipCamera);
            this.Controls.Add(this.tbNrCamera);
            this.Controls.Add(this.labelNrCamera);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditare;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox tbTipCamera;
        private System.Windows.Forms.Label labelTipCamera;
        private System.Windows.Forms.TextBox tbNrCamera;
        private System.Windows.Forms.Label labelNrCamera;
    }
}