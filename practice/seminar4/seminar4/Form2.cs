using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar4
{
    public partial class Form2 : Form
    {
        //declar si in clasa form2 lista
        List<Suv> lista2;
        public Form2(List<Suv> lista)
        {
            lista2 = lista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Suv s in lista2)
            {
                textBox1.Text += s.ToString() + Environment.NewLine;
            }
        }
    }
}
