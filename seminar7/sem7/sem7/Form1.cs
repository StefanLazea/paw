using System;
using System.Collections; //aici aveam Generics dar pt ca fac colectie, il scot
using System.Collections.Generic; //ca sa pot sa declar lista de produse
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem7
{
    public partial class Form1 : Form
    {
        ArrayList listaTb = new ArrayList();
        List<Produs> listaProd = new List<Produs>();

        public Form1()
        {
            InitializeComponent();
            listaTb.Add(textBox1);
            listaTb.Add(textBox2);
            listaTb.Add(textBox3);
            listaTb.Add(textBox4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butonul adauga linie de textboxuri automat; textboxurile vor fi pastrate intr-o colectie
            int x=((TextBox)listaTb[0]).Location.X; //coord x a textboxului
            int y = ((TextBox)listaTb[listaTb.Count - 1]).Location.Y; //coord y
            int dist = ((TextBox)listaTb[1]).Location.X - ((TextBox)listaTb[0]).Location.X; //dif primelor textboxuri din colectie
            for(int i = 0; i < 4; i++)
            {
                TextBox tb = new TextBox();  //creez nou textbox
                tb.Location = new Point(x, y + 30);
                tb.Size = new System.Drawing.Size(100, 22); //asta nuj daca trebuie
                x += dist + 20; //ma mut 
                if (i == 1 || i == 2)
                    tb.KeyPress += new KeyPressEventHandler(textBox2_KeyPress); //evenimentul de keypress aferent textbox2 atasez aceeasi functie lui tb 
                //keypresseventhandler e public delegate void si e un fel de pointer la functie si primeste ca parametru functia de mai jos
                if (i == 3)
                    tb.ReadOnly = true;
                listaTb.Add(tb); //trb adaugat in colectia mea
                this.Controls.Add(tb); //trb adaugat in formular
            }

        }

        //proprietati->fulger->keypress->double click
        // evenimentele tastaturii key down, key press, key up 
        //evenimentele mouseului: mouse down, mouse move, mouse up, mouse wheel(pt scroll)
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar=='.') //clasa atasata mesajelor primite de acest textbox este KeyPressEventArgs
                //(char)8 e backspace pt stergere
                //keychar caract aferent tastei apasate
                {
                e.Handled = false; //false-evenimentul nu se considera tratat, adica ast
            }
            else e.Handled = true; //se considera tratat

        } //pt a extinde validarea la casuta de cantitate: textbox3->fulger->keypress->functie textbox2_keyPress


        //buton care calc toate valorile din formular
        private void button2_Click(object sender, EventArgs e)
        {
            float total = 0;
            for(int i = 0; i < listaTb.Count; i += 4) //merg din 4 in 4 casute
            {
                if(((TextBox)listaTb[i]).Text=="")
                   errorProvider1.SetError((TextBox)listaTb[i], "Introduceti denumire!");
                else if (((TextBox)listaTb[i+1]).Text == "")
                errorProvider1.SetError((TextBox)listaTb[i], "Introduceti pretul!");
                else if (((TextBox)listaTb[i + 2]).Text == "")
                 errorProvider1.SetError((TextBox)listaTb[i], "Introduceti cantitatea!");
                else
                {
                    try
                    {   //extragem denumirea, pretul si cantitatea
                        string denumire = ((TextBox)listaTb[i]).Text;
                        float pret =(float) Convert.ToDouble(((TextBox)listaTb[i + 1]).Text);
                        float cantitate=(float)Convert.ToDouble(((TextBox)listaTb[i + 2]).Text);

                         float valoare = pret * cantitate; //calculez val pt fiecare linie
                        ((TextBox)listaTb[i + 3]).Text = valoare.ToString();
                        total += valoare; //calculez totalul

                        //instantiez produs
                        Produs p = new Produs(denumire, pret, cantitate);
                        //adaug produs in lista
                        listaProd.Add(p);

     


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        errorProvider1.Clear(); //daca sunt toate completata sa dispara bulina rosie
                    }
                }
                tb_total.Text = total.ToString(); //pun totalul in casuta de total

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaProd); //trimitem colectia de produse din form1 in form2 !!SE DA LA TEST
            frm.ShowDialog(); //afiseaza formular 2
           

        }
    }
}
