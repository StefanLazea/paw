﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace _1043_Lazea_Stefan
{
    public partial class Grafice : Form
    {
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10; 
        Color culoare = Color.Blue;
        Color culoarePieChart = Color.Black;
        Color culoarePieF = Color.Red;
        Color culoarePieM = Color.Blue;

        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        String connString;

        Graphics g;
        Bitmap bmp;

        public Grafice()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = proiect.accdb";
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
            this.CenterToScreen();

        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                vect[nrElem] = Convert.ToDouble(line);
                nrElem++;
                vb = true;
            }

            sr.Close();
            MessageBox.Show("date incarcate!");
            panel1.Invalidate(); // de fiecare data cand fac o schimbare, trebuie sa apelez din nou si sa se redeseneze graficul
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                //daca avem datele incarcate
                /*4 metode
                Graphics g = panel1.CreateGraphics();
                Graphics g = Graphics.FromHwnd(panel1.Handle());
                Graphics g = Graphics.FromImage(img);
                */
                Graphics g = e.Graphics; //diverse metode pentru desenare

                Rectangle rect = new Rectangle(
                    panel1.Location.X + marg,
                    panel1.Location.Y + 4 * marg,
                    panel1.Width - 2 * marg,
                    panel1.Height - 5 * marg
                    );

                Pen pen = new Pen(Color.Red, 3);

                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3; //impart la 3 pentru a ramane si spati intre ele
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1); //pentru a face distantele mici dintre coloane
                //nr*elemente *latime este suma distantelor mici
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                //vector de elemente de tip dreptunghi coresp elementelor din vector
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle(
                        (int)(rect.Left + (i + 1) * distanta + (i * latime)),
                        (int)(rect.Bottom - vect[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rect.Height)
                        );

                    g.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen,
                        new Point((int)(recs[i].Location.X + latime / 2),
                        recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
                }
            }
            else
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        void pd_print(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics; //diverse metode pentru desenare

                Rectangle rect = new Rectangle(
                    e.PageBounds.X + marg,
                    e.PageBounds.Y + 4 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 5 * marg
                    );

                Pen pen = new Pen(Color.Red, 3);

                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3; //impart la 3 pentru a ramane si spati intre ele
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1); //pentru a face distantele mici dintre coloane
                //nr*elemente *latime este suma distantelor mici
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                //vector de elemente de tip dreptunghi coresp elementelor din vector
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle(
                        (int)(rect.Left + (i + 1) * distanta + (i * latime)),
                        (int)(rect.Bottom - vect[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rect.Height)
                        );

                    g.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen,
                        new Point((int)(recs[i].Location.X + latime / 2),
                        recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
                }
            }
            else
            {
                Graphics grap = e.Graphics;

                Rectangle rect = new Rectangle(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, e.PageBounds.Height);

                Pen pen = new Pen(Color.Blue, 3);

                grap.DrawRectangle(pen, rect);
                               
                OleDbConnection conexiune = new OleDbConnection(connString);
                OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM clienti", conexiune);


                DataSet ds = new DataSet();
                adaptor.Fill(ds, "clienti");

                DataTable tabela = ds.Tables["clienti"];

                DataRow[] rowsMGender = tabela.Select("sex = 'Masculin'", "nume");
                int nrBarbati = 0;
                foreach (DataRow linie in rowsMGender)
                {
                    nrBarbati++;
                }

                DataRow[] rowsFGender = tabela.Select("sex = 'Feminin'", "nume");
                int nrFete = 0;
                foreach (DataRow linie in rowsFGender)
                {
                    nrFete++;
                }

                int total = nrFete + nrBarbati;

                float x = (360 * nrFete) / total;
                float y = (360 * nrBarbati) / total; 


                Pen pen1 = new Pen(culoarePieChart, 3);
                Rectangle rec = new Rectangle(250, 250, 300, 150);
                Brush br11 = new SolidBrush(culoarePieF);
                Brush br1 = new SolidBrush(culoarePieM);
                grap.DrawEllipse(pen1, rec);
                grap.FillPie(br11, rec, 0, x);
                grap.FillPie(br1, rec, x, y);
                grap.DrawString("femei", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                  new SolidBrush(Color.Black), new Point(270, 120));

                grap.DrawString("barbati", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                   new SolidBrush(Color.Black), new Point(270, 90));


            }
        }
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void piechartToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adapt = new OleDbDataAdapter("SELECT * FROM clienti", conexiune);

            DataSet ds = new DataSet();
            adapt.Fill(ds, "clienti");
     
            DataTable tabela = ds.Tables["clienti"];

            DataRow[] rowsMGender = tabela.Select("sex = 'Masculin'", "nume");
            int nrBarbati = 0;
            foreach (DataRow row in rowsMGender)
            {
                nrBarbati++;
            }

            DataRow[] rowsFGender= tabela.Select("sex = 'Feminin'", "nume");
            int nrFete = 0;
            foreach (DataRow linie in rowsFGender)
            {
                nrFete++;
            }


            int total = nrFete + nrBarbati;

            float x = (360 * nrFete) / total;
            float y = (360 * nrBarbati) / total;



            Pen pen = new Pen(Color.Black, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            Brush brWomen = new SolidBrush(culoarePieF);
            Brush br1 = new SolidBrush(culoarePieM);
            g.DrawEllipse(pen, rec);

            if(nrFete == 0)
            {
                g.FillPie(br1, rec, x, y);
                g.DrawString("barbati", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
               new SolidBrush(Color.Black), new Point(270, 90));
            }
            else if(nrBarbati == 0)
            {
                g.FillPie(brWomen, rec, 0, x);
                g.DrawString("femei", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                     new SolidBrush(Color.Black), new Point(270, 120));
            }
            else
            {
                g.FillPie(brWomen, rec, 0, x);
                g.FillPie(br1, rec, x, y);

                g.DrawString("femei", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                   new SolidBrush(Color.Black), new Point(270, 120));

                g.DrawString("barbati", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                   new SolidBrush(Color.Black), new Point(270, 90));
            }
           

            panel1.Invalidate();
        }
    }
}
