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
using System.Runtime.Serialization.Formatters.Binary; //de retinut!

namespace WindowsFormsAppSeminar5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "(*.txt)|*.txt"; //extensia efectiv e dupa pipe
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);

                //StreamWriter sw = new StreamWriter(dlg.FileName);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }

            
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
            }
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dlg.Color;
            }


        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat",FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();
            Student s1 = new Student(40, "Prost", 9.5f);
            Student s2 = new Student(22, "Dorel", 9.5f);
            List<Student> lista = new List<Student>();
            lista.Add(s1);
            lista.Add(s2);

            bf.Serialize(fs, lista);
            //bf.Serialize(fs, textBox1.Text);
            fs.Close();
            textBox1.Clear();
            
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();

            // returneaza object bf.Deserialize(fs);
            // Student s = (Student)bf.Deserialize(fs);
            List<Student> lista1 = (List<Student>)bf.Deserialize(fs);
            foreach(Student s in lista1)
            {
                textBox1.Text += s.ToString() + Environment.NewLine;
            }

            //textBox1.Text = s.ToString();
            //textBox1.Text = (string)bf.Deserialize(fs);

            fs.Close();
        }
    }
}
