using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_adauga_Click(object sender, EventArgs e)
        {
            try {
                int cod = Convert.ToInt32(tb_cod.Text);
                char sex = Convert.ToChar(cb_sex.Text);
                int varsta = Convert.ToInt32(tb_varsta.Text);
                string nume = tb_nume.Text;
                float medie = (float)Convert.ToDouble(tb_medie.Text);

                string[] sNote = tb_note.Text.Split(',');

                int[] note = new int[sNote.Length];
                for(int i = 0; i < sNote.Length; i++)
                {
                    note[i] = Convert.ToInt32(sNote[i]);
                }

                Student s = new Student(cod, sex, varsta, nume, medie, note);
                MessageBox.Show(s.ToString());
                listaStud.Add(s);
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_cod.Text = "";
                cb_sex.Text = "";
                tb_medie.Clear();
                tb_note.Clear();
                tb_varsta.Clear();
                tb_nume.Clear();


            }



        }

        private void button_lista_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.Show();
        }
    }
}
