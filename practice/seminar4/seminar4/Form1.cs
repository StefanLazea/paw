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
    public partial class Form1 : Form
    {
        List<Suv> listaSuv = new List<Suv>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                string tip = tbTip.Text;
                string model = tbModel.Text;
                int nrOptiuni = Convert.ToInt32(tbNrOptiuni.Text);
                float pret = (float)Convert.ToDouble(tbPret.Text);

                string[] sPretOptiuni = tbPretOptiuni.Text.Split(',');
                float[] pretOptiuni = new float[sPretOptiuni.Length];
                for(int i = 0; i < sPretOptiuni.Length; i++)
                {
                    pretOptiuni[i] = (float)Convert.ToDouble(sPretOptiuni[i]);
                }
                Suv s = new Suv(model, nrOptiuni, pretOptiuni, pret, tip);
                MessageBox.Show(s.ToString());
                listaSuv.Add(s);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbModel.Clear();
                tbNrOptiuni.Text = "";
                tbPret.Text = "";
                tbPretOptiuni.Text = "";
                tbTip.Text = "";
            }
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(listaSuv);
            form.Show();
        }
    }
}
