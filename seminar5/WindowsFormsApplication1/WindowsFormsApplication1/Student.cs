using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{   [Serializable] //ca sa poate fi serializat
    class Student
    {
        private int varsta;
        private string nume;
        private float medie;

        public Student(int v, string n, float m)
        {
            varsta = v;
            nume = n;
            medie = m;
        }

        public override string ToString()
        {
            return "Studentul " + nume + " are varsta " + varsta + " si media " + medie;
        }

    }
}
