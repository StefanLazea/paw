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

namespace baza_1043
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune; //al doilea parametru

            try
            {
                conexiune.Open();
                comanda.CommandText = "Select MAX(cod) FROM comenzi";
                int cod = Convert.ToInt32(comanda.ExecuteScalar()); // returneaza valoarea
                comanda.CommandText = "INSERT INTO comenzi VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod + 1;
                //comanda.Parameters["cod"].Value = cod + 1;
                comanda.Parameters.Add("denumire", OleDbType.Char,30).Value = tbDenumire.Text;
                comanda.Parameters.Add("nrProd", OleDbType.Integer).Value = Convert.ToInt32(tbNrProduse.Text);
                comanda.Parameters.Add("tipPlata", OleDbType.Char, 20).Value = cbPlata.Text;
                comanda.Parameters.Add("valoare", OleDbType.Integer).Value = Convert.ToInt32(tbValoare.Text);
                comanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbDenumire.Clear();
                tbNrProduse.Clear();
                tbValoare.Clear();
                cbPlata.Text = "";
            }
        }
    }
}
