using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Zoo:ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale; //list e colectie predefinita; <> restrictioneaza tipul elementelor din list la cele din clasa Animal

        public Zoo()
        {
            denumire = "Zoo Baneasa";
            listaAnimale = new List<Animal>(); //mereu se defineste asa
        }
        //proprietati

        public string Denumire
        {
            get { return denumire; }
            set
            {
                denumire = value;
            }
        }

        public List<Animal> ListaAnimale //List<Animal> e ca un tip de date
        {
            get { return listaAnimale; }
            set
            {
                listaAnimale = value;
            }
        }

        public Zoo Clone()
        {
            Zoo clona = (Zoo)this.MemberwiseClone(); //fac un shallow copy pt zoo
            List<Animal> copie = new List<Animal>();
            foreach (Animal a in listaAnimale)
                copie.Add((Animal)a.Clone()); //am copiat toate animalele din lista animale care e in zoo, in alt zoo
            clona.listaAnimale = copie;
            return clona;
        }

        public override string ToString()
        {
            string result = "";
            result += denumire + " are urmatoarele animale "+Environment.NewLine;
            foreach (Animal a in listaAnimale)
                result += a.ToString() + Environment.NewLine;
            return result;
        }
    }
}
