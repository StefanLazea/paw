using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace Smartphones
{
    public partial class Form1 : Form
    {
        ArrayList devices = new ArrayList();
        ArrayList allDevices = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            
            AdaugareDate();
            AfisareDate();
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            List<Device> lista = new List<Device>();
            foreach(Device d in devices)
            {
                lista.Add(d);
            }
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Device>));
            FileStream stream = new FileStream("fisieeer.xml", FileMode.Create, FileAccess.Write);
            serializer.Serialize(stream, lista);
            stream.Close();
        }

        public void AdaugareDate()
        {
            Smartphone sm = new Smartphone(2, 1, "Samsung S10", "500x450", 2, 4, "Android", 5000, true);
            Smartphone sm2 = new Smartphone(2, 2, "Huawei", "500x450", 4, 4, "Android", 2500, false);

            Tablet t1 = new Tablet(2, 3, "Ipad", "10 inch", 3, 4, "iOS", 3400, true);
            Tablet t2 = new Tablet(2, 4, "Tab10", "10 inch", 4, 5, "Android", 3000, false);

            devices.Add(sm);
            devices.Add(sm2);
            devices.Add(t1);
            devices.Add(t2);

          
        }

        public void AfisareDate()
        {
            listView1.Items.Clear();
            foreach(Device d in devices)
            {
                listView1.Items.Add(d.Afisare());
            }
            foreach (Device d in allDevices)
            {
                listView1.Items.Add(d.Afisare());
            }
        }

        private void adaugaDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 adaugare = new Form2();
            adaugare.ShowDialog();
            this.allDevices.Add(adaugare.DeviceAdaugat);
            AfisareDate();
        }
    }
}
