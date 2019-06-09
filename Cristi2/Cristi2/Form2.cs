using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cristi2
{
    public partial class Form2 : Form
    {
        private string connString;
        public Form2()
        {
            InitializeComponent();
            this.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cristi.accdb";
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            listViewCamere.Items.Clear();

            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM camera", conexiune);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["id"].ToString());
                    itm.SubItems.Add(reader["numar"].ToString());
                    itm.SubItems.Add(reader["tipCamera"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    listViewCamere.Items.Add(itm);
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand();

            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                foreach(ListViewItem itm in listViewCamere.Items)
                {
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM camera where id=" + id;
                        comanda.ExecuteNonQuery();

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            Form2_Activated(sender, e);
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listViewCamere.Items)
            {
                if (itm.Selected)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    Form3 form = new Form3(id);
                    form.ShowDialog();
                }
            }
        }

       
    }
}
