using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphones
{
    public abstract class Device
    {
        private int cod;
        private string denumire;
        private string dimensiuni;
        private float frecvproc;
        private int nrcore;
        private string sistemop;
        private float pret;
        private bool activ;

        protected Device(int cod, string denumire, string dimensiuni, float frecvproc, int nrcore, string sistemop, float pret, bool activ)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.dimensiuni = dimensiuni;
            this.frecvproc = frecvproc;
            this.nrcore = nrcore;
            this.sistemop = sistemop;
            this.pret = pret;
            this.activ = activ;
        }


        public int Cod
        {
            get { return cod; }
            set { this.cod = value; }
        }

        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }

        public string Dimensiune
        {
            get { return this.dimensiuni; }
            set { this.dimensiuni = value; }
        }

        public float Frecvproc
        {
            get{ return this.frecvproc; }
            set
            {
                this.frecvproc = value;
            }
        }

        public int Nrcore
        {
            get { return this.nrcore; }
            set { this.nrcore = value; }
        }

        public string Sistemop
        {
            get { return this.sistemop; }
            set { this.sistemop = value; }
        }
        public float Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        } 
        public bool Activ
        {
            get { return this.activ; }
            set { this.activ = value; }
        }

        public abstract ListViewItem Afisare();

        public override string ToString()
        {
            return "device-ul " + this.denumire + " cu codul " + this.cod + " si denumirea " + this.denumire + " are " + this.nrcore + " nuclee si " + this.frecvproc + "\r\nc"
                + " frecventa procesor, dar si dimensiunea " + this.dimensiuni + " la pretul de " + this.pret;
        }
    }
}
