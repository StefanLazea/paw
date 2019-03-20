using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Persoana
    {
        int cod;
        char sex;

        public Persoana()
        {
            cod = 0;
            sex = 'F';
        }

        public Persoana(int c, char s)
        {
            cod = c;
            sex = s;
        }

        public override string ToString()
        {
            return "Persoana are codul " + cod + " si sexul " + sex;
        }
    }
}
