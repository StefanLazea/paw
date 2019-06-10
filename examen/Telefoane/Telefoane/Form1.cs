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

namespace Telefoane
{
    public partial class Form1 : Form
    {
        List<Producator> producatori;
        List<Smartphone> telefoane = new List<Smartphone>();
        public Form1(List<Producator> lista)
        {
            this.producatori = lista;
            InitializeComponent();
            initializare_producatori();
            afisare_producatori(this.producatori);
            afisare_telefoane();

        }
        private void initializare_producatori()
        {
            Producator p1 = new Producator(100, "APPLE");
            Producator p2 = new Producator(211, "SAMSUNG");
            Producator p3 = new Producator(121, "LG");
            Producator p4 = new Producator(324, "SONY");
            Producator p5 = new Producator(123, "NEXUS");
            Producator p6 = new Producator(110, "GOOGLE");
            this.producatori.Add(p1);
            this.producatori.Add(p2);
            this.producatori.Add(p3);
            this.producatori.Add(p4);
            this.producatori.Add(p5);
            this.producatori.Add(p6);

        }
        private void afisare_producatori(List<Producator> producatori)
        {
            dataGridView1.Rows.Clear();
            foreach (Producator producator in producatori)
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells["Id"].Value = producator.Id;
                dataGridView1.Rows[row].Cells["Denumire"].Value = producator.Denumire;
                dataGridView1.Rows[row].Tag = producator;
            }
        }

        private void afisare_telefoane()
        {
            
            StreamReader sr = new StreamReader("telefoane.txt");

            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                String[] values = line.Split(',');
                int id = Convert.ToInt32(values[0]);
                string model = values[1];
                int stocDisp = Convert.ToInt32(values[2]);
                float pret = (float)Convert.ToDouble(values[3]);
                string dataAparitie = values[4];
                int idProducator = Convert.ToInt32(values[5]);
                Smartphone s = new Smartphone(id, model, stocDisp, pret, dataAparitie, idProducator);
                telefoane.Add(s);
            }

            listView1.Items.Clear();

            foreach(Smartphone s in telefoane)
            {
                ListViewItem itm = new ListViewItem(s.Id.ToString());
                itm.SubItems.Add(s.Model);
                itm.SubItems.Add(s.StocDisp.ToString());
                itm.SubItems.Add(s.Pret.ToString());
                itm.SubItems.Add(s.DataAparitie.ToString());
                itm.SubItems.Add(s.IdProducator.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void buttonAdaugareProducatori_Click(object sender, EventArgs e)
        {
            Form2 formular = new Form2();
            formular.ShowDialog();
            this.producatori.Add(formular.Prod);
            afisare_producatori(this.producatori);
           
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Form2 formular = new Form2();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                formular.Prod = (Producator)row.Tag;
                formular.ShowDialog();
                afisare_producatori(this.producatori);

            }
        }
    }
}
