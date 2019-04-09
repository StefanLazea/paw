using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    public class Automobil
    {
        private float pret;
        private string tip;

        public Automobil()
        {
            this.pret = 0;
            this.tip = "n/a";
        }
        
        public Automobil(float pret, string tip)
        {
            this.pret = pret;
            this.tip = tip;
        }

        public float Pret
        {
            get { return this.pret; }
            set
            {
                if(value > 0)
                {
                    this.pret = value;
                }
            }
        }
        
        public string Tip
        {
            get { return this.tip; }
            set
            {
                if (value != null)
                {
                    this.tip = value;
                }
            }
        }

        public override string ToString()
        {
            return "Masina este de tipul: " + this.Tip + " si costa " + this.Pret;
        }
    }
}
