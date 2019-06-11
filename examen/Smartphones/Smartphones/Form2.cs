using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Smartphones
{
    public partial class Form2 : Form
    {
        private Device deviceAdaugat;
        private string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=smartphones.accdb";
        int max = 0;
        public Form2()
        {
            InitializeComponent();
            InitializareComboBox();
            calculareMaxim();
        }

        public void InitializareComboBox()
        {
            this.comboBox1.Items.Add("Smartphone");
            this.comboBox1.Items.Add("Tablet");
        }

        public void calculareMaxim()
        {
            OleDbConnection conexiune = new OleDbConnection(this.connString);
            OleDbCommand comanda = new OleDbCommand("SELECT MAX(cod) FROM devices", conexiune);

            try
            {
                conexiune.Open();
                this.max = Convert.ToInt32(comanda.ExecuteScalar()) + 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        public Device DeviceAdaugat
        {
            get { return this.deviceAdaugat; }
            set { this.deviceAdaugat = value; }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Smartphone"))
            {
                deviceAdaugat = new Smartphone(
                    Convert.ToInt32(textBoxSimUsb.Text),
                    this.max,
                    textBoxDenumire.Text,
                    textBoxDimensiuni.Text,
                    (float)Convert.ToDouble(textBoxProcesor.Text),
                    Convert.ToInt32(textBoxNuclee.Text),
                    textBoxSo.Text,
                    (float)Convert.ToDouble(textBoxPret.Text),
                    true//Convert.ToBoolean(textBoxActiv.Text)
                    );

                MessageBox.Show(deviceAdaugat.ToString());
                this.Close();

                
            }else if (comboBox1.Text.Equals("Tablet"))
            {
                deviceAdaugat = new Tablet(
                   Convert.ToInt32(textBoxSimUsb.Text),
                   this.max,
                   textBoxDenumire.Text,
                   textBoxDimensiuni.Text,
                   (float)Convert.ToDouble(textBoxProcesor.Text),
                   Convert.ToInt32(textBoxNuclee.Text),
                   textBoxSo.Text,
                   (float)Convert.ToDouble(textBoxPret.Text),
                   true//Convert.ToBoolean(textBoxActiv.Text)
                   );
                MessageBox.Show(deviceAdaugat.ToString());
                this.Close();

            }


        }
    }
}
