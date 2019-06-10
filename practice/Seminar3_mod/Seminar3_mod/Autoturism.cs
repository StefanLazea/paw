using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_mod
{
    class Autoturism : Vehicul, ICloneable, IComparable, IConsum
    {

        private int putere;
        private string marca;
        private float[] consum;


        public Autoturism():base()
        {
            this.putere = 0;
            this.marca = "n/a";
            this.consum = null;
        }

        public Autoturism(int putere, string marca, float[] consum, int nrRoti, string propulsie):base(nrRoti, propulsie)
        {
            this.putere = putere;
            this.marca = marca;
            this.consum = new float[consum.Length];
            for(int i = 0; i < consum.Length; i++)
            {
                this.consum[i] = consum[i];
            }
        }

        public int Putere {
            get { return this.putere; }
            set
            {
                if(value != 0)
                {
                    this.putere = value;
                }
            }
        }
        public string Marca
        {
            get { return this.marca; }
            set
            {
                if(value != null)
                {
                    this.marca = value;
                }
            }
        }

        public float[] Consum
        {
            get { return this.consum; }
            set
            {
                if(value.Length != 0)
                {
                    this.consum = new float[value.Length];
                    for(int i = 0; i < value.Length; i++)
                    {
                        this.consum[i] = value[i];
                    }
                }
            }
        }

        public float calculareConsumMediu()
        {
            float suma = 0;
            for(int i = 0; i < this.consum.Length; i++)
            {
                suma += this.consum[i];
            }
            return suma / this.consum.Length;
        }

        public static explicit operator float(Autoturism p)
        {
            return p.calculareConsumMediu();
        }

        public static Autoturism operator +(Autoturism auto, float consum) {
            float[] consumNou = new float[auto.consum.Length + 1];

            for(int i = 0; i < auto.consum.Length; i++)
            {
                consumNou[i] = auto.consum[i];
            }
            consumNou[auto.consum.Length - 1] = consum;

            auto.consum = consumNou;
            return auto;
        }

        public static Autoturism operator ++(Autoturism s)
        {
            return s + 1;
        }

        public float this[int index]
        {
            get
            {
                if(consum!=null && index>=0 && index <= consum.Length)
                {
                    return this.consum[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(value > 0)
                {
                    this.consum[index] = value;
                }
            }
        }

        public object Clone()
        {
            Autoturism clona = (Autoturism)this.MemberwiseClone();
            float[] cons = (float[])this.consum.Clone();
            clona.consum = cons;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Autoturism auto = (Autoturism)obj;

            if(this.putere > auto.putere)
            {
                return 1;
            }
            else
            {
                if (this.putere < auto.putere)
                {
                    return -1;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + " are o putere de " + this.putere + " si este marca " + this.marca;
        }
    }
}
