using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //pentru Access

namespace baza_1043
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // o sa stearga doar inregistrarile; pentru a nu fi dublate
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM comenzi", conexiune);


            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader(); //un obiect de tip datareader; container
                while (reader.Read())
                {
                    //ptr a popula list item ul

                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["nrProd"].ToString());
                    itm.SubItems.Add(reader["tipPlata"].ToString());
                    itm.SubItems.Add(reader["valoare"].ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune; //al doilea parametru

            try
            {
                conexiune.Open();
                foreach (ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM comenzi where cod=" + cod;// "'";
                        comanda.ExecuteNonQuery(); //comenzile pentru manipulare

                    }
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
            button1_Click(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
