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
using System.IO;

namespace _1043_Lazea_Stefan
{
    public partial class adaugareRecenzie : Form
    {
        int idFilm;
        string connString;

        public adaugareRecenzie(int id, string connString)
        {
            idFilm = id;
            this.connString = connString;
            InitializeComponent();
            this.CenterToScreen();

        }

        private void adaugareRecenzie_Load(object sender, EventArgs e)         
        {
            Filme film = Filme.getOneById(connString, idFilm);
            tbDenumire.Text = film.Denumire;
            string denumireCategorie = Categorie.findCategoryNameById(connString, film.IdCategorie);
            tbCategorie.Text = denumireCategorie;

            tbDataLansare.Text = film.Datalansare.ToString();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(idFilm);
                sw.WriteLine(cbNota.SelectedItem.ToString());
                sw.WriteLine(tbDescriere.Text);
                sw.Close();
            }

        }

        private void buttonAdaugaRecenzie_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conn;

            try
            {
                conn.Open();
                comanda.CommandText = "Select MAX(id) FROM recenzii";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                int nota = Convert.ToInt32(cbNota.SelectedItem.ToString());
                string descriere = tbDescriere.Text;

                Recenzie rec = new Recenzie(id, nota, descriere, idFilm);
                rec.save(connString);

                MessageBox.Show("Succes");

                afisareFilme form = new afisareFilme();
                this.Hide();
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

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                
                this.idFilm = Convert.ToInt32(sr.ReadLine());
                cbNota.SelectedItem = sr.ReadLine();
                tbDescriere.Text = sr.ReadLine();                
                sr.Close();
            }
        }
    }
}
