using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043_Lazea_Stefan
{
    class Clienti
    {
        private int id;
        private string nume;
        private string prenume;
        private string adresa;
        private string telefon;
        
        public Clienti()
        {

        }

        public Clienti(
            int id,
            string nume, 
            string prenume, 
            string adresa,
            string telefon
        ) {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.telefon = telefon;
        }

    }
}
