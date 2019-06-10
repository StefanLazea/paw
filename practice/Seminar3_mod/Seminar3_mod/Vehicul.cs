using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_mod
{
    abstract class Vehicul
    {
        int nrRoti;
        string propulsie;

        public Vehicul()
        {
            this.nrRoti = 0;
            this.propulsie = "N/a";
        }

        public Vehicul(int nrRoti, string propulsie)
        {
            this.nrRoti = nrRoti;
            this.propulsie = propulsie;
        }

        public override string ToString()
        {
            return "Acest vehicul are " + this.nrRoti + " roti si e propulsat prin " + this.propulsie;
        }
    }
}
