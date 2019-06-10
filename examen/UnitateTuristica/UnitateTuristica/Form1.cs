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
using System.Runtime.Serialization.Formatters.Binary;

namespace UnitateTuristica
{
    public partial class Form1 : Form
    {
        List<Camera> camere;
        public Form1(List<Camera> lista)
        {
            this.camere = lista;
            InitializeComponent();
            this.CenterToScreen();
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.camere);
            fs.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.camere.Sort();
            foreach (Camera c in this.camere)
            {
                if (c.EsteOcupata != false)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(c.NrCamera));
                    item.SubItems.Add(c.TipCamera);
                    item.SubItems.Add(Convert.ToString(c.EsteOcupata));
                    item.SubItems.Add(c.DataOcupare);
                    item.Tag = c;
                    listView1.Items.Add(item);
                }
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                {
                    Camera camera = (Camera)itm.Tag; // tag pentru a pastra referinta la obiect
                    Form2 form = new Form2(camera);
                    form.ShowDialog();
                }
            }

        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                listView1.ForeColor = dlg.Color;
            }
        }

        private void buttonDeserializare_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            this.camere = (List<Camera>)bf.Deserialize(fs);
            fs.Close();
            Form1_Activated(sender, e);
        }
    }
}
