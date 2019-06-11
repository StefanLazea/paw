using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace FirmaDistributie
{
    public partial class Form2 : Form
    {
        private List<Furnizor> furnizori = new List<Furnizor>();
        private string connString;
        private Produs produs;
        public Form2(Produs produs)
        {
            preluare_furnizori();
            this.produs = produs;
            InitializeComponent();
            this.connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=firma.accdb";
            if(this.produs != null)
            {
                adaugaDate();
                this.buttonEditare.Text = "Editare";
            }
        }

        private void adaugaDate()
        {
            //textBoxId.Text = this.produs.Id.ToString();
            textBoxNume.Text = this.produs.Nume;
            textBoxPret.Text = this.produs.Pret.ToString();
            textBoxUnitati.Text = this.produs.Unitati.ToString();

            //comboBoxFurnizori.SelectedText
        }

        private void preluare_furnizori()
        {
            StreamReader reader = new StreamReader("furnizori.txt");
            String linie = null;
            while ((linie = reader.ReadLine()) != null)
            {
                try
                {
                    int id = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];

                    Furnizor f = new Furnizor(id, nume);
                    this.furnizori.Add(f);

                }catch(Exception ex)
                {
                    MessageBox.Show("Exceptie la citirea din fisier\r\n" + ex.Message);
                }
            }
        }
        private void buttonEditare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            if (this.produs == null)
            {
                try
                {
                    conexiune.Open();
                    comanda.CommandText = "SELECT MAX(ID) FROM produse";

                    int idMax = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO produse VALUES(?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = idMax + 1;
                    comanda.Parameters.Add("nume", OleDbType.Char, 50).Value = textBoxNume.Text;
                    comanda.Parameters.Add("unitati", OleDbType.Integer).Value = Convert.ToInt32(textBoxUnitati.Text);
                    comanda.Parameters.Add("pret", OleDbType.Integer).Value = Convert.ToDecimal(textBoxPret.Text);
                    comanda.Parameters.Add("idFurnizor", OleDbType.Integer).Value = this.getIdFromSelected();
                    comanda.ExecuteNonQuery();

                    MessageBox.Show("Date introduse!");
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
            else
            {
                
                try
                {
                    conexiune.Open();

                    comanda.CommandText = "UPDATE produse set nume='" + textBoxNume.Text + "', unitati='" + textBoxUnitati.Text + "', pret='"
                        + textBoxPret.Text + "', idFurnizor='" + this.getIdFromSelected().ToString() + "' where id=" + this.produs.Id;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Date modificate!");
                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("update " + ex.Message);
                }
            }
           
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            foreach(Furnizor f in furnizori)
            {
                comboBoxFurnizori.Items.Add(f.Nume);
            }
        }

        private int getIdFromSelected()
        {
            string nume = comboBoxFurnizori.SelectedItem.ToString();
            foreach(Furnizor f in furnizori)
            {
                if(f.Nume == nume)
                {
                    return f.Id;
                }
            }
            return 0;
        }

    }
}
