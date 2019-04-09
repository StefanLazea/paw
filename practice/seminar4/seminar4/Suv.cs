using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    public class Suv : Automobil, ICloneable, IComparable
    {
        private string model;
        private int numarOptiuni;
        private float[] pretOptiuni;

        public Suv():base() {
            this.model = "n/a";
            this.numarOptiuni = 0;
            this.pretOptiuni = null;
        }

        public Suv(
            string model, 
            int numarOptiuni,
            float[] pretOptiuni,
            float pret,
            string tip
        ) : base(pret, tip) {

            this.model = model;
            this.numarOptiuni = numarOptiuni;
            this.pretOptiuni = new float[numarOptiuni];
            for(int i = 0; i < this.numarOptiuni; i++)
            {
                this.pretOptiuni[i] = pretOptiuni[i];
            }
        }

        public static explicit operator float(Suv v)
        {
            return v.Pret + v.calculPretOptiuni();
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value != null)
                {
                    this.model = value;
                }
            }
        }

        public int NumarOptiuni
        {
            get { return this.numarOptiuni; }
            set
            {
                if(value > 0)
                {
                    this.numarOptiuni = value;
                }
            }
        }

        public float[] PretOptiuni
        {
            get { return this.pretOptiuni; }
            set
            {
                if (value != null)
                {
                    this.pretOptiuni = value;
                }
            }
        }

        public object Clone()
        {
            Suv nou = (Suv)this.MemberwiseClone();
            nou.numarOptiuni = this.numarOptiuni;
            nou.pretOptiuni = (float[])pretOptiuni.Clone();
            return nou;
        }

        public int CompareTo(object obj)
        {
            Suv suv = (Suv)obj;
            if(suv.calculPretOptiuni() > this.calculPretOptiuni())
            {
                return 1;
            }
            else
            {
                if(suv.calculPretOptiuni() < this.calculPretOptiuni())
                {
                    return -1;
                }
                else
                {
                    return string.Compare(this.model, suv.model);
                }
            }
        }

        public static Suv operator +(Suv v, float optiune)
        {
            float[] optiuniActualizate = new float[v.numarOptiuni + 1];
            for(int i=0; i< v.numarOptiuni; i++)
            {
                optiuniActualizate[i] = v.pretOptiuni[i];
            }
            optiuniActualizate[v.numarOptiuni-1] = optiune;
            v.pretOptiuni = optiuniActualizate;
            return v;
        }

        public override string ToString()
        {
            string rezultat = base.ToString() + " fiind modelul " + this.model;
            if(this.numarOptiuni != 0)
            {
                if(this.numarOptiuni == 1)
                {
                    rezultat += " si are ca pret de optiune " + this.pretOptiuni[0];
                }
                else
                {
                    rezultat += " si are ca preturi pentru optiuni: ";
                    for(int i = 0; i < this.numarOptiuni; i++)
                    {
                        rezultat += this.pretOptiuni[i] + " / ";
                    }
                }
            }
            return rezultat; 
        }

        public float calculPretOptiuni()
        {
            float pret = 0;
            for(int i = 0; i < this.numarOptiuni; i++)
            {
                pret += this.pretOptiuni[i];
            }
            return pret;
        }
    }
}
