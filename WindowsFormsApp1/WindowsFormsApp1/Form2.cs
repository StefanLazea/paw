using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            lista2 = lista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Student s in lista2)
            {
                textBox2.Text += s.ToString() + Environment.NewLine;
            }
        }
    }
}
