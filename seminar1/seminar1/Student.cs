using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    class Student
    {
        public int varsta;
        private string nume;
        public float medie;

        public Student() //constructor default(fara parametrii)
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
        }

        public Student(int v, string n, float m) //constructor cu parametrii
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
        }

        public Student(Student s) //constructor de copiere
        {
            varsta = s.varsta;
            nume = s.nume;
            medie = s.medie;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value; //value=cuv cheie cu care se initializeaza noul nume
            }
        }
    }
}


  
