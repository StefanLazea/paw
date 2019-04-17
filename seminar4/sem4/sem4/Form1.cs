using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem4
{
    public partial class Form1 : Form
    {
        //pt a pastra studentii, definim o colectie

        List<Student> listaStud =new List<Student>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //toate valorile introduse sunt siruri de caractere
            if (tb_cod.Text == null)
            {
                tb_cod.Focus();
                errorProvider1.SetError(tb_cod, "esti prost");

            }
            else
            {
                try
                {
                    int cod = Convert.ToInt32(tb_cod.Text); //text imi da proprietatea(textul) introdus in casuta; 
                                                            //ConvertTo transforma stringul in int pe 32 de biti
                    char sex = Convert.ToChar(tb_sex.Text);
                    int varsta = Convert.ToInt32(tb_varsta.Text);
                    string nume = tb_nume.Text;
                    float medie = (float)Convert.ToDouble(tb_medie.Text); //nu exista convert to float

                    string[] sNote = tb_note.Text.Split(',');
                    int[] note = new int[sNote.Length];
                    for (int i = 0; i < sNote.Length; i++)
                        note[i] = Convert.ToInt32(sNote[i]);
                    //split returneaza un vector de siruri de caract

                    //instantiez student
                    Student s = new Student(varsta, nume, medie, note, cod, sex);
                    MessageBox.Show(s.ToString()); //apelam metoda to string din student si persoana
                    listaStud.Add(s); //adauga fiecare student in lista

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //in caz ca introducem iar un string in loc de int si nu-l poate converti; proprietatea Message afiseaza o eroare
                                                 //MessageBox.Show afiseaza e fereastra de notificare care afiseaza eroare; nu exista console readline/writeline
                }
                finally//blocul finally din try-catch se executa intotdeauna(chiar daca intra pe try sau catch)
                {
                    tb_cod.Text = ""; //facem sirul vid; stergem ce am scris dupa ce se executa
                    tb_sex.Text = ""; //blocul combo nu are metoda clear
                    tb_varsta.Clear(); //sau folosim metoda clear de stergere inregistrare
                    tb_nume.Clear();
                    tb_medie.Clear();
                    tb_note.Clear();
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creez instanta Form2
            Form2 frm=new Form2(listaStud); //dau lista ca parametru in constructor form2; o adaug si ca parametru in constructorul lui Form2
            //frm.ShowDialog(); //se afiseaza fereastra pt form2 in ac timp cu form2 dar nu mai pot scrie in form
            frm.Show();

        }
    }
}

//formularul se mai numeste macheta de preluare date