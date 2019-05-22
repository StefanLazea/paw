using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1043_Lazea_Stefan
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void buttonFilme_Click(object sender, EventArgs e)
        {
            afisareFilme form = new afisareFilme();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inchiriereFilm form = new inchiriereFilm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grafice form = new Grafice();
            form.ShowDialog();
        }

        private void buttonCategoriePreferata_Click(object sender, EventArgs e)
        {
            CategoriePreferata form = new CategoriePreferata();
            form.ShowDialog(); 
        }
    }
}
