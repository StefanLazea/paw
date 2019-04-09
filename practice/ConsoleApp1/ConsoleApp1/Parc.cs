using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Parc:ICloneable
    {
        private string denumire;
        private List<Masina> listaMasini;

        public Parc()
        {
            denumire = "parc vitan";
            listaMasini = new List<Masina>();
        }

        public string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                denumire = value;
            }
        }

        public List<Masina> ListaMasini
        {
            get
            {
                return listaMasini;
            }
            set
            {
                listaMasini = value;
            }
        }

        public object Clone()
        {
            Parc clona = (Parc)this.MemberwiseClone();
            List<Masina> copie = new List<Masina>();
            foreach(Masina m in listaMasini)
            {
                copie.Add((Masina)m.Clone());
            }
            clona.listaMasini = copie;
             
            return clona;
        }

        public override string ToString()
        {
            string result = "";
            result += denumire + " are urmatoarele masini: " + Environment.NewLine;
            foreach(Masina m in listaMasini)
            {
                result += m.ToString() + Environment.NewLine;
            }

            return result;
        }
    }
}
