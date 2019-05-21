﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    public partial class afisareFilme : Form
    {
        string connString;
        public afisareFilme()
        {
            InitializeComponent();
            this.CenterToScreen();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            try
            {
                List<Filme> listaFilme = Filme.getAllMovies(connString);
                foreach (Filme filme in listaFilme)
                {
                    ListViewItem itm = new ListViewItem(filme.Id.ToString());
                    itm.SubItems.Add(filme.Denumire);
                    string denumire = Categorie.findCategoryNameById(connString, filme.IdCategorie);
                    itm.SubItems.Add(denumire);
                    itm.SubItems.Add(filme.Datalansare.ToString());
                    itm.SubItems.Add(filme.Durata.ToString());
                    itm.SubItems.Add(filme.PretInchiriere.ToString());
                    listView1.Items.Add(itm);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
       
        private void adaugaFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareFilm formAdaugare = new adaugareFilm();
            this.Hide();
            formAdaugare.ShowDialog();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    Filme.deleteMovie(connString, id);
                }
            }
            Form3_Activated(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    Filme.deleteMovie(connString, id);
                }
            }
            Form3_Activated(sender, e);
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            inchiriereFilm form = new inchiriereFilm();
            this.Hide();
            form.ShowDialog();
       }
    }
}
