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
using System.Xml;

namespace seminar9
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            CitireDate();
        }

        public void CitireDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie=sr.ReadLine())!=null)
            {
                try
                {
                    int cod = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    int nota = Convert.ToInt32(linie.Split(',')[2]);

                    Student s = new Student(cod, nume, nota);
                    listaStudenti.Add(s);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            MessageBox.Show("Date incarcate");

            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Student s in listaStudenti)
            {
                ListViewItem itm = new ListViewItem(s.cod.ToString());

                itm.SubItems.Add(s.nume);
                itm.SubItems.Add(s.nota.ToString());
                if(s.nota > 8)
                {
                    itm.SubItems.Add("excelent");
                }
                else
                {
                    itm.SubItems.Add("bunicel");

                }

                listView1.Items.Add(itm);
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                {
                    itm.Remove();
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                {
                    itm.Remove();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);

            foreach(Student s in listaStudenti)
            {
                TreeNode copil = new TreeNode(s.cod + "," + s.nume + "," + s.nota);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.nota > 8)
                {
                    nepot.Text = "excelent";
                }
                else
                {
                    nepot.Text = "bunicel";
                }
                copil.Nodes.Add(nepot);
            }

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            int cod;

            try
            {
                cod = Convert.ToInt32(nodSelectat.Text.Split(','));
                foreach(Student s in listaStudenti)
                {
                    if (s.cod == cod)
                    {
                        textBox1.Text += s.ToString() + Environment.NewLine;
                    }
                }
            }
            catch
            {
                cod = 0;
            }

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memoryStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            foreach(TreeNode parinte in treeView1.Nodes)
            {
                writer.WriteStartElement(parinte.Text);

                foreach(TreeNode copil in parinte.Nodes)
                {
                    writer.WriteStartElement(copil.Text);

                    foreach(TreeNode nepot in copil.Nodes)
                    { 
                        writer.WriteStartElement(nepot.Text);
                        writer.WriteEndElement();                    
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
            writer.WriteEndDocument();
            writer.Close();

            string xml = Encoding.UTF8.GetString(memoryStream.ToArray());
            memoryStream.Close();

            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(xml);
            sw.Close();

            MessageBox.Show("fisier generat");
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            if (nodSelectat.NextNode != null)
            {
                nodSelectat = treeView1.SelectedNode.NextNode;
            }
            else
            {
                if (nodSelectat.PrevNode != null)
                {
                    nodSelectat = treeView1.SelectedNode.PrevNode;
                }

                treeView1.SelectedNode.Remove();
                treeView1.SelectedNode = nodSelectat;
            }
        }
    }
}
