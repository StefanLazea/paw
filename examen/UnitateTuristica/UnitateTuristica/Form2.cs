using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitateTuristica
{
    public partial class Form2 : Form
    {
        Camera camera;
        public Form2(Camera camera)
        {
            this.camera = camera;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNrCamera.Text))
            {
                errorProvider1.SetError(tbNrCamera, "Introduceti o valoare");
            } else if (string.IsNullOrWhiteSpace(tbTipCamera.Text))
            {
                errorProvider1.SetError(tbTipCamera, "Introduceti o valoare");
            }else if(string.IsNullOrWhiteSpace(tbOcupare.Text))
            {
                errorProvider1.SetError(tbOcupare, "Introduceti o valoare");
            }else if (string.IsNullOrWhiteSpace(tbData.Text))
            {
                errorProvider1.SetError(tbData, "Introduceti o valoare");
            } else
            {
                camera.NrCamera = Convert.ToInt32(tbNrCamera.Text);
                camera.TipCamera = tbNrCamera.Text;
                camera.EsteOcupata = Convert.ToBoolean(tbOcupare.Text);
                camera.DataOcupare = tbData.Text;
                this.Close();
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            tbNrCamera.Text = Convert.ToString(this.camera.NrCamera);
            tbTipCamera.Text = this.camera.TipCamera;
            tbOcupare.Text = Convert.ToString(this.camera.EsteOcupata);
            tbData.Text = Convert.ToString(this.camera.DataOcupare);
        }
    }
}
