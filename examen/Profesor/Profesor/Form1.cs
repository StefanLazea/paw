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

namespace Profesor
{
    public partial class Form1 : Form
    {
        private Profesor[] profesori;
        private string connString;
        private int max;
        public Form1()
        {
            this.profesori = new Profesor[]{};
            this.connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=scoala.accdb";
            initializareDate();
            initializeazaMaxim();
            adaugareInBaza();
            InitializeComponent();
            afisareDate();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            //Profesor p = (Profesor)currentRow.Tag;
            //MessageBox.Show(p.ToString());


            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();
                comanda.CommandText = "UPDATE tblProfesor set nume='" + currentRow.Cells[1].Value.ToString() + "', salariu='"
                    + Convert.ToInt32(currentRow.Cells[2].Value.ToString()) + "' where marca=" + Convert.ToInt32(currentRow.Cells[0].Value.ToString());
                comanda.ExecuteNonQuery();
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

        public void initializareDate()
        {
            Profesor p = new Profesor(1, "antonescu", 10000);
            Profesor p2 = new Profesor(2, "ionescu", 20000);
            Profesor p3 = new Profesor(3, "marinescu", 40000);

            this.profesori = new Profesor[3] { p, p2, p3};
        }

        public void adaugareInBaza()
        {
            if (this.max < 3)
            {
                OleDbConnection conexiune = new OleDbConnection(this.connString);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                try
                {
                    conexiune.Open();
                    foreach (Profesor p in profesori)
                    {
                        
                        comanda.CommandText = "INSERT INTO tblProfesor VALUES(?,?,?)";
                        comanda.Parameters.Add("marca", OleDbType.Integer).Value = p.Marca;
                        comanda.Parameters.Add("nume", OleDbType.Char, 40).Value = p.Nume;
                        comanda.Parameters.Add("salariu", OleDbType.Double).Value = p.Salariu;

                        comanda.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("esti prost" + ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }


        public void initializeazaMaxim()
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand("SELECT MAX(marca) FROM tblProfesor", conexiune);

            try
            {
                conexiune.Open();
                this.max = Convert.ToInt32(comanda.ExecuteScalar());
                MessageBox.Show("Exista " + this.max + " profesori.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Maxim error" + ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
        void afisareDate()
        {
            dataGridView1.Rows.Clear();
            if (this.max < 2)
            {
                foreach (Profesor p in profesori)
                {
                    int row = dataGridView1.Rows.Add();//indexul pe care punem noua intrare
                    dataGridView1.Rows[row].Cells["marca"].Value = p.Marca;
                    dataGridView1.Rows[row].Cells["nume"].Value = p.Nume;
                    dataGridView1.Rows[row].Cells["salariu"].Value = p.Salariu;
                    dataGridView1.Rows[row].Tag = p;
                }
            }
            else
            {
                OleDbConnection conexiune = new OleDbConnection(this.connString);
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM tblProfesor", conexiune);
               
                try
                {
                    conexiune.Open();
                    OleDbDataReader reader = comanda.ExecuteReader();

                    while (reader.Read())
                    {
                        int row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Cells["marca"].Value = Convert.ToInt32(reader["marca"].ToString());
                        dataGridView1.Rows[row].Cells["nume"].Value = reader["nume"].ToString();
                        dataGridView1.Rows[row].Cells["salariu"].Value = Convert.ToDouble(reader["salariu"].ToString());
                    }

                   
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach(Profesor p in profesori)
            {
                total += p;
            }
            MessageBox.Show("totalul este " +total);
        }
    }
}
