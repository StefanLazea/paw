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

namespace Cabinet
{
    public partial class Form2 : Form
    {
        private Pacient pacient;
        private string connString;
        public Form2(Pacient pacient)
        {
            this.pacient = pacient;
            this.connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = cabinet.accdb";
            InitializeComponent();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            textBoxId.Text = this.pacient.IdPacient.ToString();
            textBoxIdMedic.Text = this.pacient.IdMedic.ToString();
            textBoxNume.Text = this.pacient.Nume;
            textBoxData.Text = this.pacient.Data;
            textBoxOra.Text = this.pacient.Ora;
        }

        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();

            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;

                comanda.CommandText = "UPDATE pacienti set nume='" + textBoxNume.Text + "', idMedic='"
                    + Convert.ToInt32(textBoxIdMedic.Text) + "', data='" + textBoxData.Text + "', ora='" + textBoxOra.Text + "' where ID=" + this.pacient.IdPacient;
                comanda.ExecuteNonQuery();
                MessageBox.Show("S-a modificat in: \r\n pacientul cu id-ul " + textBoxId.Text + " cu numele " + textBoxNume.Text + " avand programare la data \r\n " 
                    + textBoxData.Text + " si ora " + textBoxData.Text + " la medicul " + textBoxIdMedic.Text);

                this.Close();
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
}
