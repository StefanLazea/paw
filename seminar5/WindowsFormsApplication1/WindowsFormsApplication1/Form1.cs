using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //includ bibiloteca pt lucru cu fisiere
using System.Runtime.Serialization.Formatters.Binary;//DE RETINUT!!!!

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LUCRU CU MENIU PRINCIPAL
        //pt salvare fisier
        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e) //functia care apare cand apas "Salveaza"
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt"; //ca sa salvez altundeva
           // saveFileDialog1.Filter = "(*.txt)|*.txt";
            //daca vr sa nu salvez fisierul in locatia predefinita
            //clasa necesara pt a genera un fisier pe disc si pt a scrie pe el StreamWriter
            if (dlg.ShowDialog() == DialogResult.OK) //dialogresult.ok ma ajuta sa validez ca am salvat
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write); //bagam linia asta din serializare ca sa fim siguri
                StreamWriter sw = new StreamWriter(fs); //sau "fisier.txt" daca il salvez in calea predefinita
                sw.WriteLine(textBox1.Text); //iau continutul din textbox1 si il scriu in fisier
                sw.Close();//inchid fisier
                textBox1.Clear(); //golesc textboxul ptc continutul se duce in fisier
                //dau run, scriu ceva, Fisier->Salveaza, click dreapta proiect open file source explorer->bin->debug
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //pt citire din fisier
        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd(); //readToEnd citeste tot
                sr.Close();
            }


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg=new FontDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
                textBox1.Font=dlg.Font; 
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg=new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
                textBox1.ForeColor=dlg.Color;
        }

        //LUCRU CU MENIU CONTEXTUAL(CONTEXT MENU STRIP)->SE ACTIVEAZA LA CLICK DREAPTA DE MOUSE; trb sa-i fac o legatura cu un control; 
        //la orice lista de prop apare context menu strip->il setez din proprietati=>am legat acel meniu la textbox deci daca rulez+ fac click dr imi apar prop
        //SERIALIZARE-transforma un obiect de orice tip in sectiune de bytes;
        //conditie ce trb respecta:obiectele pe care le trimite ca parametrii sa fie serializabile(ex clasa Student nu e, dar->[serializable])
        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write); //parametrii astia sunt mereu aceeasi la serializare
            //filestream se poate combina cu streamreader sau streamwriter
            BinaryFormatter bf = new BinaryFormatter();
           // bf.Serialize(fs, textBox1.Text); //textbox1.Text e de tip String deci e serializabil
            Student s1 = new Student(21, "Gigel", 9.3f); //creez student
            Student s2 = new Student(22, "Dorel", 9.3f);
            List<Student> stud=new List<Student>();
            stud.Add(s1);
            stud.Add(s2);
            bf.Serialize(fs, stud);
            fs.Close();
            textBox1.Clear();
         }
        //DESERIALIZARE-din binar in ce era
        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read); //parametrii astia sunt mereu aceeasi la serializare
            //filestream se poate combina cu streamreader sau streamwriter
            BinaryFormatter bf = new BinaryFormatter();
            //prin numele functiei returneaza continutul deserializar
            //textBox1.Text = (string)bf.Deserialize(fs); //fac cast ca functia returneaza object dar eu am string
            //Student s = (Student)bf.Deserialize(fs);
            List<Student> lista = (List<Student>)bf.Deserialize(fs);
            foreach(Student s in lista)
               textBox1.Text+= s.ToString()+Environment.NewLine;
            //textBox1.Text = s.ToString();
            fs.Close();

        }






        

    }
}
