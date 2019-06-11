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

namespace FirmaDistributie
{
    public partial class Form1 : Form
    {
        private string connString;
        public Form1()
        {
            this.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = firma.accdb";
            InitializeComponent();
            incarcaDatele();
        }

        private void incarcaDatele()
        {
            listView1.Items.Clear();

            List<Produs> produse = new List<Produs>();

            OleDbConnection connection = new OleDbConnection(this.connString);
            OleDbCommand command = new OleDbCommand("SELECT * FROM produse", connection);

            try
            {
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string nume = reader["nume"].ToString();
                    int unitati = Convert.ToInt32(reader["unitati"].ToString());
                    decimal pret = Convert.ToDecimal(reader["pret"].ToString());
                    int idFurnizor = Convert.ToInt32(reader["idFurnizor"].ToString());

                    Produs p = new Produs(id, nume, unitati, pret, idFurnizor);
                    produse.Add(p);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            produse.Sort();
            foreach(Produs p in produse)
            {
                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Nume);
                item.SubItems.Add(p.Unitati.ToString());
                item.SubItems.Add(p.Pret.ToString());
                item.SubItems.Add(p.IdFurnizor.ToString());
                item.Tag = p;
                listView1.Items.Add(item);
            }


        }

        private void buttonProduse_Click(object sender, EventArgs e)
        {
            Form2 adaugare = new Form2(null);
            adaugare.ShowDialog();
            incarcaDatele();
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                Produs p = (Produs)itm.Tag;
                Form2 editare = new Form2(p);
                editare.ShowDialog();
                incarcaDatele();
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Selected)
                    {
                        int id = Convert.ToInt32(item.SubItems[0].Text);
                        OleDbConnection conexiune = new OleDbConnection(this.connString);
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;

                        try
                        {
                            conexiune.Open();
                            comanda.CommandText = "DELETE FROM produse where ID=" + id;
                            comanda.ExecuteNonQuery();
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
                }
                incarcaDatele();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                Produs p = (Produs)itm.Tag;

                MessageBox.Show("totalul este " + (decimal)p);
            }
        }
    }
}
