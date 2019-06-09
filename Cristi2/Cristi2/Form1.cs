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
    public partial class Form1 : Form
    {
        private string connString;
        public Form1()
        {
            InitializeComponent();
            this.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cristi.accdb";
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;


            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT MAX(ID) from camera";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO camera VALUES(?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("numar", OleDbType.Integer).Value = Convert.ToInt32(tbNrCamera.Text);
                comanda.Parameters.Add("tipCamera", OleDbType.Char, 50).Value = tbTipCamera.Text;
                comanda.Parameters.Add("pret", OleDbType.Double).Value = Convert.ToDouble(tbPret.Text);

                comanda.ExecuteNonQuery();

                MessageBox.Show("Succes!");

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbPret.Clear();
                tbNrCamera.Clear();
                tbTipCamera.Text = "";
            }
            
        }
    }
}
