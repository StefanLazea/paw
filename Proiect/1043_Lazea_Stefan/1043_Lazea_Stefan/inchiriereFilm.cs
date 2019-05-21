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
    public partial class inchiriereFilm : Form
    {
        string connString = "";
        bool isChecked = false;
        List<Categorie> listaCategorii = new List<Categorie>();
        OleDbConnection conexiune;
        OleDbCommand comanda;

        public inchiriereFilm()
        {
            InitializeComponent();
            this.CenterToScreen();

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

                    listaCategorii.Add(new Categorie(id, denumire));
                }

                foreach (Categorie categorie in listaCategorii)
                {
                    cbCategorie.Items.Add(categorie.ToString());
                }
                cbCategorie.SelectedIndex = 0;
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

        private void rbContExistent_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbContExistent.Checked;
        }

        private void rbContExistent_Click(object sender, EventArgs e)
        {
            if (rbContExistent.Checked && !isChecked)
            {
                rbContExistent.Checked = false;
                tbAdresa.Visible = true;
                labelAdresa.Visible = true;
                labelPrenume.Visible = true;
                labelNume.Visible = true;
                labelVarsta.Visible = true;
                labelSex.Visible = true;
                labelUsername.Visible = true;
                labelPassword.Visible = true;
                labelTelefon.Visible = true;

                tbAdresa.Visible = true;
                tbNume.Visible = true;
                tbPrenume.Visible = true;
                tbSex.Visible = true;
                tbVarsta.Visible = true;
                tbTelefon.Visible = true;
                tbUsername.Visible = true;
                tbPassword.Visible = true;
                     
            }
            else
            {
                rbContExistent.Checked = true;
                tbTelefon.Hide();
                tbNume.Hide();
                labelNume.Hide();
                tbPrenume.Hide();
                labelPrenume.Hide();
                tbVarsta.Hide();
                labelVarsta.Hide();
                tbSex.Hide();
                labelSex.Hide();
                tbAdresa.Hide();
                labelAdresa.Hide();
                labelTelefon.Hide();
                isChecked = false;

                
            }
        }

        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home form = new home();
            this.Hide();
            form.ShowDialog();
        }

    }
}
