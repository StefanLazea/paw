using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem7
{
    public partial class Form2 : Form
    {
        List<Produs> lista2;
        public Form2(List<Produs> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach(Produs p in lista2)
            {
                textBox1.Text += p.ToString() + Environment.NewLine;
            }
        }
    }
}
