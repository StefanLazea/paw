namespace UnitateTuristica
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDeserializare = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(121, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 206);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numar";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status ocupare";
            this.columnHeader3.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.culoareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.culoareToolStripMenuItem.Text = "Culoare";
            this.culoareToolStripMenuItem.Click += new System.EventHandler(this.culoareToolStripMenuItem_Click);
            // 
            // buttonDeserializare
            // 
            this.buttonDeserializare.Location = new System.Drawing.Point(12, 26);
            this.buttonDeserializare.Name = "buttonDeserializare";
            this.buttonDeserializare.Size = new System.Drawing.Size(75, 23);
            this.buttonDeserializare.TabIndex = 2;
            this.buttonDeserializare.Text = "Deserializare";
            this.buttonDeserializare.UseVisualStyleBackColor = true;
            this.buttonDeserializare.Click += new System.EventHandler(this.buttonDeserializare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 345);
            this.Controls.Add(this.buttonDeserializare);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeserializare;
    }
}

