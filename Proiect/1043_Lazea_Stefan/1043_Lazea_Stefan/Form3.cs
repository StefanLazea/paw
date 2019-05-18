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

namespace _1043_Lazea_Stefan
{
    public partial class Form3 : Form
    {
        string connString;
        public Form3()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM filme", conexiune);


            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader(); 
                while (reader.Read())
                {
                    
                    ListViewItem itm = new ListViewItem(reader["id"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["gen"].ToString());
                    itm.SubItems.Add(reader["dataLansare"].ToString());
                    itm.SubItems.Add(reader["durata"].ToString());
                    itm.SubItems.Add(reader["pretInchiriere"].ToString());

                    listView1.Items.Add(itm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void adaugaFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formAdaugare = new Form1();
            this.Hide();
            formAdaugare.ShowDialog();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                foreach(ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM filme WHERE id=" + id;
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
            Form3_Activated(sender, e);
        }
    }
}
