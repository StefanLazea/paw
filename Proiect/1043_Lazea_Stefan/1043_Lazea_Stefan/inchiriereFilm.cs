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
using System.Drawing.Printing;


namespace _1043_Lazea_Stefan
{
    public partial class inchiriereFilm : Form
    {
        string connString = "";
        Clienti client;

        public inchiriereFilm()
        {
            InitializeComponent();
            this.CenterToScreen();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonContNou_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            try
            {
                List<Filme> listaFilme = Filme.getAllMovies(connString);
                foreach (Filme filme in listaFilme)
                {
                    cbFilm.Items.Add(filme.Denumire);
                }
                cbFilm.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home form = new home();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonComanda_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conn;
            try
            {
                
                int idMaxClient = getMaxIdFromDbTable("clienti");
                int idMaxComanda = getMaxIdFromDbTable("inchirieri");

            
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                string adresa = tbAdresa.Text;
                string telefon = tbTelefon.Text;
                string sex = cbSex.SelectedItem.ToString();
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                int idFilm = Filme.findMovieIdByName(connString, cbFilm.SelectedItem.ToString());
                DateTime data = Convert.ToDateTime(dateTimePicker.Text);

                client = new Clienti(idMaxClient, nume, prenume, adresa, telefon, sex, varsta, username, password);
                client.save(connString);

                Inchirieri inchiriere = new Inchirieri(idMaxComanda, data, idFilm, idMaxClient);
                inchiriere.save(connString);

                MessageBox.Show("Succes");
                this.Hide();
                afisareFilme form = new afisareFilme();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

            }
        }

        private int getMaxIdFromDbTable(string tableName)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conn;
            conn.Open();
            comanda.CommandText = "Select MAX(id) FROM " + tableName;
            return Convert.ToInt32(comanda.ExecuteScalar()) + 1;

        }

    }
}
