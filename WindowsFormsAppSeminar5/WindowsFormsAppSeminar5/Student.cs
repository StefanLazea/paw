using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSeminar5
{
    [Serializable]
    class Student
    {
        private int varsta;
        private string nume;
        private float medie;

        public Student(int varsta, string nume, float medie)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.medie = medie;
        }
        public string ToString()
        {
            return "studentul " + nume + " are varsta " + varsta + " media " + medie;
        }
    }
}
