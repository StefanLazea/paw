namespace UnitateTuristica
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
            this.components = new System.ComponentModel.Container();
            this.tbNrCamera = new System.Windows.Forms.TextBox();
            this.labelNrCamera = new System.Windows.Forms.Label();
            this.labelTipCamera = new System.Windows.Forms.Label();
            this.tbTipCamera = new System.Windows.Forms.TextBox();
            this.labelOcupare = new System.Windows.Forms.Label();
            this.tbOcupare = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNrCamera
            // 
            this.tbNrCamera.Location = new System.Drawing.Point(133, 42);
            this.tbNrCamera.Name = "tbNrCamera";
            this.tbNrCamera.Size = new System.Drawing.Size(100, 20);
            this.tbNrCamera.TabIndex = 0;
            // 
            // labelNrCamera
            // 
            this.labelNrCamera.AutoSize = true;
            this.labelNrCamera.Location = new System.Drawing.Point(41, 49);
            this.labelNrCamera.Name = "labelNrCamera";
            this.labelNrCamera.Size = new System.Drawing.Size(76, 13);
            this.labelNrCamera.TabIndex = 1;
            this.labelNrCamera.Text = "Numar camera";
            // 
            // labelTipCamera
            // 
            this.labelTipCamera.AutoSize = true;
            this.labelTipCamera.Location = new System.Drawing.Point(41, 90);
            this.labelTipCamera.Name = "labelTipCamera";
            this.labelTipCamera.Size = new System.Drawing.Size(60, 13);
            this.labelTipCamera.TabIndex = 3;
            this.labelTipCamera.Text = "Tip camera";
            // 
            // tbTipCamera
            // 
            this.tbTipCamera.Location = new System.Drawing.Point(133, 83);
            this.tbTipCamera.Name = "tbTipCamera";
            this.tbTipCamera.Size = new System.Drawing.Size(100, 20);
            this.tbTipCamera.TabIndex = 2;
            // 
            // labelOcupare
            // 
            this.labelOcupare.AutoSize = true;
            this.labelOcupare.Location = new System.Drawing.Point(41, 128);
            this.labelOcupare.Name = "labelOcupare";
            this.labelOcupare.Size = new System.Drawing.Size(48, 13);
            this.labelOcupare.TabIndex = 5;
            this.labelOcupare.Text = "Ocupata";
            // 
            // tbOcupare
            // 
            this.tbOcupare.Location = new System.Drawing.Point(133, 121);
            this.tbOcupare.Name = "tbOcupare";
            this.tbOcupare.Size = new System.Drawing.Size(100, 20);
            this.tbOcupare.TabIndex = 4;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(41, 176);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 7;
            this.labelData.Text = "Data";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(133, 169);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.labelOcupare);
            this.Controls.Add(this.tbOcupare);
            this.Controls.Add(this.labelTipCamera);
            this.Controls.Add(this.tbTipCamera);
            this.Controls.Add(this.labelNrCamera);
            this.Controls.Add(this.tbNrCamera);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNrCamera;
        private System.Windows.Forms.Label labelNrCamera;
        private System.Windows.Forms.Label labelTipCamera;
        private System.Windows.Forms.TextBox tbTipCamera;
        private System.Windows.Forms.Label labelOcupare;
        private System.Windows.Forms.TextBox tbOcupare;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}