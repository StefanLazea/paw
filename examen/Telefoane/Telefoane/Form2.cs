using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoane
{
    public partial class Form2 : Form
    {
        private Producator prod;
        public Form2()
        {
            this.prod = new Producator();
            InitializeComponent();
        }

        //getter pentru a lua producatorul nou introdus
        public Producator Prod
        {
            get { return this.prod; }
            set
            {
                if (value != null)
                {
                    this.prod = value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(textBoxId.Text))
            {
                errorProvider1.SetError(textBoxId, "Adaugati date!");
            }else if (String.IsNullOrWhiteSpace(textBoxDenumire.Text))
            {
                errorProvider1.SetError(textBoxDenumire, "Adaugati date!");
            }
            else
            {
                this.prod.Id = Convert.ToInt32(textBoxId.Text);
                this.prod.Denumire = textBoxDenumire.Text;

                MessageBox.Show("A fost adaugat producatorul " + this.prod.ToString());
                this.Close();
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            if (this.prod.Id != 0)
            {
                textBoxId.Text = Convert.ToString(this.prod.Id);
                textBoxDenumire.Text = this.prod.Denumire;
            }
        }
    }
}
