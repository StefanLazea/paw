using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Masina
    {
        private string motorizare;
        private float pret;
        private int putere;

        public Masina()
        {
            this.motorizare = "n/a";
            this.pret = 0;
            this.putere = 0;
        }

        public Masina(string motorizare, float pret, int putere)
        {
            this.motorizare = motorizare;
            this.putere = putere;
            this.pret = pret;
        }

        public int Putere
        {
            get { return putere; }

            set
            {
                if (value > 0)
                {
                    putere = value;
                }
            }
        }

        public float Pret
        {
            get { return pret; }
            set
            {
                if (value > 0)
                {
                    pret = value;
                }
            }
        }

        public string Motorizare
        {
            get { return motorizare; }
            set
            {
                if(value != null)
                {
                    motorizare = value;
                }
            }
        }
    }
}
