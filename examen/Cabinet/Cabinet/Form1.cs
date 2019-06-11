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
    public partial class Form1 : Form
    {
        private List<Medic> medici;
        private List<Pacient> pacienti;
        private string connString;

        public Form1(List<Medic> lista)
        {
            this.medici = lista;
            this.pacienti = new List<Pacient>();
            this.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cabinet.accdb";
            
            InitializeComponent();
            citireDate();

        }
        private void citireDate()
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM pacienti", conexiune);
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int idPacient = Convert.ToInt32(reader["ID"].ToString());
                    string nume = reader["nume"].ToString();
                    int idMedic = Convert.ToInt32(reader["idMedic"].ToString());
                    string data = reader["data"].ToString();
                    string ora = reader["ora"].ToString();

                    Pacient p = new Pacient(idPacient, nume, idMedic, data, ora);
                    this.pacienti.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

            MessageBox.Show("Date incarcate din baza de date");

            treeView1.Nodes.Clear();
            foreach (Medic c in medici)
            {
                TreeNode node = new TreeNode(c.IdMedic + " - " + c.Specializare);
                treeView1.Nodes.Add(node);
                if (c.IdMedic == 1)
                {
                    creeaza_copii(node, 1);
                }
                if (c.IdMedic == 2)
                {
                    creeaza_copii(node, 2);
                }
                if (c.IdMedic == 3)
                {
                    creeaza_copii(node, 3);
                }
                if (c.IdMedic == 4)
                {
                    creeaza_copii(node, 4);
                }
                if (c.IdMedic == 5)
                {
                    creeaza_copii(node, 5);
                }
            }
            treeView1.ExpandAll();
        }
      

        private void creeaza_copii(TreeNode parinte, int idMedic) {
            foreach(Pacient p in this.pacienti)
            {
                if(p.IdMedic == idMedic)
                {
                    //TreeNode copil = new TreeNode(p.ToString());
                    parinte.Nodes.Add(p.ToString());
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            int id;
            try
            {
                id = Convert.ToInt32(nodSelectat.Text.Split(',')[0]);
                foreach (Pacient p in pacienti)
                {
                    if (p.IdPacient == id)
                    {
                        textBox1.Text += "Pacientul " + p.Nume + " are programare la data de " + p.Data + Environment.NewLine
                            + " la ora " + p.Ora + " la doctorul " + p.IdMedic + Environment.NewLine;
                    }
                }
            }
            catch
            {
                id = 0;
            }

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            int id = Convert.ToInt32(nodSelectat.Text.Split(',')[0]);
            string nume = nodSelectat.Text.Split(',')[1];
            int idMedic = Convert.ToInt32(nodSelectat.Text.Split(',')[2]);
            string data = nodSelectat.Text.Split(',')[3];
            string ora = nodSelectat.Text.Split(',')[4];
            Pacient p = new Pacient(id, nume, idMedic, data, ora);
            Form2 formular = new Form2(p);
            formular.ShowDialog();
            citireDate();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            int id = Convert.ToInt32(selectedNode.Text.Split(',')[0]);

            OleDbConnection connection = new OleDbConnection(this.connString);
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM pacienti where ID=" + id;
                command.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }
    }
}
