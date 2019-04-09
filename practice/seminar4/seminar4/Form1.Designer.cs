namespace seminar4
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
            this.lbTip = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNrOptiuni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tbPretOptiuni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(158, 71);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(30, 20);
            this.lbTip.TabIndex = 0;
            this.lbTip.Text = "Tip";
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(326, 68);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(100, 26);
            this.tbTip.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(326, 117);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 26);
            this.tbModel.TabIndex = 3;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(158, 123);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(326, 173);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 26);
            this.tbPret.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pret";
            // 
            // tbNrOptiuni
            // 
            this.tbNrOptiuni.Location = new System.Drawing.Point(326, 238);
            this.tbNrOptiuni.Name = "tbNrOptiuni";
            this.tbNrOptiuni.Size = new System.Drawing.Size(100, 26);
            this.tbNrOptiuni.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numar optiuni";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(235, 415);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(151, 72);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Trimite";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tbPretOptiuni
            // 
            this.tbPretOptiuni.Location = new System.Drawing.Point(326, 283);
            this.tbPretOptiuni.Name = "tbPretOptiuni";
            this.tbPretOptiuni.Size = new System.Drawing.Size(100, 26);
            this.tbPretOptiuni.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pret optiuni";
            // 
            // buttonForm2
            // 
            this.buttonForm2.Location = new System.Drawing.Point(430, 415);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(126, 72);
            this.buttonForm2.TabIndex = 11;
            this.buttonForm2.Text = "Launch Form2";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 571);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.tbPretOptiuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.tbNrOptiuni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.lbTip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNrOptiuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox tbPretOptiuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonForm2;
    }
}

