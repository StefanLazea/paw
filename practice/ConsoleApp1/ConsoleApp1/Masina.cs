using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 { 
    class Masina: ICloneable, IComparable
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
                if (value != null)
                {
                    motorizare = value;
                }
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Masina a = (Masina)obj;
            if(this.pret < a.pret)
            {
                return -1;
            } else
            {
                if(this.pret > a.pret)
                {
                    return 1;
                }
                else
                {
                    return 0; 
                    //sau string.Compare(this.motorizare,a.motorizare);
                }
            }
        }

        public override string ToString()
        {
            return "masina functioneaza " + motorizare 
                + " are puterea de " + putere + " si costa " 
                + pret;
        }
    }
}
