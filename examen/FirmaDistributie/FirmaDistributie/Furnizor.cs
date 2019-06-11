using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDistributie
{
    public class Furnizor
    {
        private int id;
        private string nume;

        public Furnizor(int id, string nume)
        {
            this.id = id;
            this.nume = nume;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }
        
        public string Nume
        {
            get
            {
                return this.nume;
            }
            set
            {
                this.nume = value;
            }
        }
    }
}
