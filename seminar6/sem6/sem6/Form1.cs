using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adaug
using System.IO;
using System.Xml;

namespace sem6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //citire continut fisier+il duc intr-un string in memorie
            StreamReader sr = new StreamReader("nbrfxrates.xml"); //il ia din folderul Debug; StreamReader se fol pt citirea din fisier
            string str = sr.ReadToEnd(); //continutul o sa fie in memorie in str
            sr.Close(); //inchid fisier

            XmlReader reader = XmlReader.Create(new StringReader(str)); //StringReader ma ajuta sa citesc un string intr-un format parsabil
            while (reader.Read()) //citeste cuvant cu cuvant
            {
                if (reader.Name == "PublishingDate"&&reader.NodeType==XmlNodeType.Element)//Name=numele tagului; Element=tag de inceput
                {
                    reader.Read(); //ma duce pe valoarea nodului; sunt poz pe data
                    tb_data.Text = reader.Value; //preia valoarea datei si o pune in textboxul data

                }

                if(reader.Name=="Rate"&&reader.NodeType==XmlNodeType.Element)
                {
                    //extrag atributul currency(care e nodul cu valuta ce mi trebuie)
                    string atribut = reader["currency"]; //ii dau denumirea atributului
                    if (atribut == "EUR")
                    {
                        reader.Read(); //ajung pe val nodului
                        tb_Eur.Text = reader.Value; //pun valoarea nodului
                    }
                    else if (atribut == "USD")
                    {
                        reader.Read(); //ajung pe val nodului
                        tb_USD.Text = reader.Value; //pun valoarea nodului
                    }
                    else if (atribut == "GBP")
                    {
                        reader.Read(); //ajung pe val nodului
                        tb_GBP.Text = reader.Value; //pun valoarea nodului
                    }
                    else if (atribut == "XAU")
                    {
                        reader.Read(); //ajung pe val nodului
                        tb_XAU.Text = reader.Value; //pun valoarea nodului
                    }
     
                }
            }



        }

        //generare fisier XML-incapsulare flux de octeti in memorie
        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream(); //aici se genereaza fisierul; trb transformat in format text
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8); //memstream+format
            writer.Formatting = Formatting.Indented; //indenteaza nodurile in functie de relatia ierarhica

            
            writer.WriteStartDocument();//metode obligatorii, responsabile de generarea primei linii cu xml version si encoding option
            writer.WriteStartElement("Curs BNR");

            writer.WriteStartElement("Data Curs");
            writer.WriteValue(tb_data.Text); //iau valoarea din textboxul de data si o pun in fisier
            writer.WriteEndElement();
            writer.WriteStartElement("Curs EUR: ");
            writer.WriteAttributeString("Valuta", "EUR");
            writer.WriteValue(tb_Eur.Text); 
            writer.WriteEndElement();
            writer.WriteStartElement("Curs USD: ");
            writer.WriteAttributeString("Valuta", "USD");
            writer.WriteValue(tb_USD.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("Curs GBP: ");
            writer.WriteAttributeString("Valuta", "GBP");
            writer.WriteValue(tb_GBP.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("Curs XAU: ");
            writer.WriteAttributeString("Valuta", "XAU");
            writer.WriteValue(tb_XAU.Text);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();

            //conversie de la memory stream la string
            string str = Encoding.UTF8.GetString(memStream.ToArray()); //trb retinuta asa cum e
            memStream.Close();

            //pun str in fisier txt
            StreamWriter sw = new StreamWriter("fisier.txt");
            sw.WriteLine(str);
            sw.Close();

            MessageBox.Show("Fisier generat.");


        }
    }
}
