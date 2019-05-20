using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043_Lazea_Stefan
{
    class Inchirieri
    {
        private int id;
        private DateTime dataReturnare;
        private string denumire;
        private Filme film;
        private Clienti client;

        public Inchirieri()
        {

        }

        public Inchirieri(int id,  DateTime dataReturnare, string denumire, Clienti client)
        {
            this.id = id;
            this.dataReturnare = dataReturnare;
            this.denumire = denumire;
        }

    }
}
