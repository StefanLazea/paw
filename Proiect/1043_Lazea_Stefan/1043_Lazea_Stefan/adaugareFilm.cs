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
    public partial class adaugareFilm : Form
    {
        string connString;
        string imgPath = "D:\\paw\\paw\\Proiect\\1043_Lazea_Stefan\\1043_Lazea_Stefan\\bin\\Debug\\default-movie.jpg";
        int pictureBoxWidth = 0;
        int pictureBoxHeight = 0;

        public adaugareFilm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conn;

            if (tbDenumire.Text == "")
            {
                errorProvider1.SetError(tbDenumire, "Introduceti denumire");

            }
            else if (tbGen.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbGen, "Introduceti gen");
            }
            else if (tbDurata.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbDurata, "Introduceti durata (min)");
            }
            else if (tbPret.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbPret, "Introduceti pretul");
            }                        
            else
            {
                errorProvider1.Clear();
                try
                {
                    conn.Open();
                    comanda.CommandText = "Select MAX(id) FROM filme";
                    int id = Convert.ToInt32(comanda.ExecuteScalar());

                    comanda.CommandText = "INSERT INTO filme VALUES(?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("id", OleDbType.Integer).Value = id + 1;
                    comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = tbDenumire.Text;
                    comanda.Parameters.Add("gen", OleDbType.Char, 30).Value = tbGen.Text;
                    comanda.Parameters.Add("data", OleDbType.Date).Value = dateTimePicker.Text.ToString();
                    comanda.Parameters.Add("durata", OleDbType.Double).Value = Convert.ToDouble(tbDurata.Text);
                    comanda.Parameters.Add("pretInchiriere", OleDbType.Double).Value = Convert.ToDouble(tbPret.Text);
                    comanda.Parameters.Add("picture", OleDbType.Char).Value = imgPath;

                    comanda.ExecuteNonQuery();

                    MessageBox.Show("Succes");

                    this.Hide();
                    Form3 form = new Form3();
                    form.ShowDialog();
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
        

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxHeight = pictureBox1.Height;
                pictureBoxWidth = pictureBox1.Width;

                //pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.Image = (Image)(new Bitmap(new Bitmap(open.FileName), new Size(pictureBoxWidth, pictureBoxHeight)));
                
                imgPath = open.FileName; // get image path
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
