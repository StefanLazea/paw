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
    public partial class Form5 : Form
    {
        string connString = "";
        List<Categorii> listaCategorii = new List<Categorii>();
        OleDbConnection conexiune;
        OleDbCommand comanda;

        public Form5()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";
            conexiune = new OleDbConnection(connString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonContNou_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comanda = new OleDbCommand("SELECT * FROM categorii", conexiune);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"].ToString());
                    string denumire = reader["denumire"].ToString();

                    listaCategorii.Add(new Categorii(id, denumire));
                }

                foreach (Categorii categorie in listaCategorii)
                {
                    cbCategorie.Items.Add(categorie.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
