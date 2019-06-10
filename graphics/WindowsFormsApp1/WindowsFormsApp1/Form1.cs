using System;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10; //readonly poate fi initializat ulterior
        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold); // A 4-A varianta

        public Form1()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string line = null;
            while((line = sr.ReadLine()) != null)
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
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        void pd_print(object sender, PrintPageEventArgs e)
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
                    e.PageBounds.X+ marg,
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
        }
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                culoare = dlg.Color;
            }
            panel1.Invalidate();

        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                font = dlg.Font;
            }
            panel1.Invalidate();

        }
    }
}
