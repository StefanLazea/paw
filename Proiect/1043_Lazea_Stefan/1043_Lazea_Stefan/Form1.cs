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
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conn;

            try
            {
                conn.Open();
                comanda.CommandText = "Select MAX(id) FROM filme";
                int id = Convert.ToInt32(comanda.ExecuteScalar()); 

                comanda.CommandText = "INSERT INTO filme VALUES(?,?,?,?,?,?)";
                comanda.Parameters.Add("id", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = tbDenumire.Text;
                comanda.Parameters.Add("gen", OleDbType.Char, 30).Value = tbGen.Text;
                comanda.Parameters.Add("durata", OleDbType.Double).Value = Convert.ToDouble(tbDurata.Text);
                comanda.Parameters.Add("pretInchiriere", OleDbType.Double).Value = Convert.ToDouble(tbPret.Text);
                
                comanda.Parameters.Add("data", OleDbType.Date).Value = dateTimePicker.Text.ToString();

                comanda.ExecuteNonQuery();

                MessageBox.Show("Succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                
            }

        }
    }
}
