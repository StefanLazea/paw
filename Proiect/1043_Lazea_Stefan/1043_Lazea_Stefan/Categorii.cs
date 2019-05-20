using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043_Lazea_Stefan
{
    class Categorii
    {
        private int id;
        private string denumire;
        
        public Categorii(int id, string denumire)
        {
            this.id = id;
            this.denumire = denumire;
        }

        public override string ToString()
        {
            return this.denumire;
        }
    }
}
