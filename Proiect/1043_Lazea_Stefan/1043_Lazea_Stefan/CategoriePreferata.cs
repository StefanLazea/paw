using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1043_Lazea_Stefan
{
    public partial class CategoriePreferata : Form
    {
        private List<Categorie> categorii;
        string connString;
        ListViewItem itmToBeRemoved;
        private List<Categorie> categoriiPreferate;

        public CategoriePreferata()
        {
            InitializeComponent();
            this.CenterToScreen();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";

        }
      
        private void CategoriePreferata_Load(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Space;
            inchideAplicatiaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Escape;
           
            try
            {
                categorii= Categorie.getAllCategories(connString);
                foreach (Categorie categorie in categorii)
                {
                    ListViewItem itm = new ListViewItem(categorie.Id.ToString());
                    itm.SubItems.Add(categorie.Denumire);
                    listView2.Items.Add(itm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {

            foreach (ListViewItem itm in listView2.Items)
            {
                if (itm.Selected)
                {
                    itmToBeRemoved = itm;
                    listView2.DoDragDrop(itm.SubItems[0].Text, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }    
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();

            textBox1.Text += "text";
     
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }
    }

}
