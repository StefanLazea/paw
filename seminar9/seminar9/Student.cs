using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9
{
    class Student
    {
        public int cod;
        public string nume;
        public int nota;

        public Student(int cod, string nume, int nota)
        {
            this.cod = cod;
            this.nume = nume;
            this.nota = nota;
        }

        public override string ToString()
        {
            return "studentul " +this.nume +" cu codul " + this.cod +" si nota " + this.nota;
        }
    }
}
