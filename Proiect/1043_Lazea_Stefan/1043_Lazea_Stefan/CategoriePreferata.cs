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

        private List<Categorie> categoriiPreferate;

        public CategoriePreferata()
        {
            InitializeComponent();
            this.CenterToScreen();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();

            listBox1.Items.Add("bou");

            Categorie curs = new Categorie();

           
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else if (((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

      
        private void CategoriePreferata_Load(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            
            try
            {
                categorii= Categorie.getAllCategories(connString,"");
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
                    listView2.DoDragDrop(itm.SubItems[0].Text, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }
            
        }
    }
      
}
