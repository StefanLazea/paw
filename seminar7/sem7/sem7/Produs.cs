using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem7
{
    public class Produs
    {
        private string denumire;
        private float cantitate;
        private float pret;

        public Produs(String d, float p, float c)
        {
            denumire = d;
            pret = p;
            cantitate = c;
        }

        public override string ToString()
        {
            return "Produsul " + denumire + " are pretul " + " cantitatea " + cantitate + " si valoarea " + pret * cantitate;
        }
    }
}
