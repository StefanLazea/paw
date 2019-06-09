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
    public partial class Form3 : Form
    {
        private int id;
        // "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cristi.accdb";
        private string connString;
        OleDbConnection conexiune; 
        public Form3(int id)
        {
            InitializeComponent();
            this.id = id;
            this.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = cristi.accdb";
        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            conexiune = new OleDbConnection(this.connString);

            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                this.conexiune.Open();
                comanda.CommandText = "UPDATE camera set numar='" + Convert.ToInt32(tbNrCamera.Text)+ "', tipCamera='" 
                    + tbTipCamera.Text + "', pret='" + Convert.ToDouble(tbPret.Text) + "' where id=" + this.id;
              
                comanda.ExecuteNonQuery();

                MessageBox.Show("S-a modificat in: \r\n camera cu numarul " + tbNrCamera.Text + " este de tip " + tbTipCamera.Text + " si costa " + tbPret.Text);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conexiune.Close();
            }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {

            //SELECTARE IN FUNCTIE DE ID
            conexiune = new OleDbConnection(this.connString);

            OleDbCommand comanda = new OleDbCommand("SELECT * FROM camera WHERE id=" + this.id, this.conexiune);

            try
            {
                this.conexiune.Open();

                OleDbDataReader reader = comanda.ExecuteReader();
                if (reader.Read()) //if pentru ca in mod normal o sa ai cu id ul dat doar o inregistrare
                {

                    //aici populezi formularul cu datele obiectului pentru care vrei sa faci update 
                    tbNrCamera.Text =reader["numar"].ToString();
                    tbTipCamera.Text = reader["tipCamera"].ToString();
                    tbPret.Text = reader["pret"].ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " This error is from loading the data.");
            }
            finally
            {
                this.conexiune.Close();
            }

        }
    }
}
