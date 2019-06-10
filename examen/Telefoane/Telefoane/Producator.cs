using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoane
{
    public class Producator
    {
        private int id;
        private string denumire;

        public Producator()
        {
            this.id = 0;
            this.denumire = "n/a";
        }

        public Producator(int id, string denumire)
        {
            this.id = id;
            this.denumire = denumire;
        }

        public int Id
        {
            get { return this.id; }
            set {
                if (value != 0)
                {
                    this.id = value;
                }
            }
        }

        public string Denumire
        {
            get { return this.denumire; }
            set
            {
                if (value != null)
                {
                    this.denumire = value;
                }

            }
        }

        public override string ToString()
        {
            return "id " + this.id + " si denumirea " + this.denumire;
        }

        public static explicit operator Producator(string v)
        {
            throw new NotImplementedException();
        }
    }
}
