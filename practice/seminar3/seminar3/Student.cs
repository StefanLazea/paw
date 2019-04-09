using System;
using System.Collections.Generic;
using System.Text;

namespace seminar3
{
    class Student : Persoana, IMedie, ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float medie;

        private int[] note;

        public Student() : base()
        {
            this.varsta = 0;
            this.nume = "n/a";
            this.medie = 0.0f;
            this.note = null;
        }

        public Student(
            int cod,
            char sex,
            int varsta,
            string nume,
            float medie,
            int[] note
            ) : base(cod, sex)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.medie = medie;
            this.note = new int[note.Length];
            for (int i = 0; i < note.Length; i++)
            {
                this.note[i] = note[i];
            }
        }

        public static explicit operator float(Student v)
        {
            return v.calculareMedie();
        }

        public static Student operator +(Student s, int nota)
        {
            //pentru ca vreau sa adaug inca o nota prin s3 +=10;
            int[] noteNou = new int[s.note.Length + 1];
            for(int i = 0; i < s.note.Length; i++)
            {
                noteNou[i] = s.note[i];
            }
            noteNou[s.note.Length - 1] = nota;
            s.note = noteNou;

            return s;
        }


        public static Student operator ++(Student s)
        {
            return s + 1;
        }

        public int this[int index]
        {
            get
            {
                if(note !=null && index>=0 && index <= note.Length)
                {
                    return note[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(value > 0)
                {
                    note[index] = value;
                }
            }
        }
        public float Medie
        {
            get { return medie; }
            set
            {
                if(value > 0)
                {
                    this.medie = value;
                }
            }
        }

        public int Varsta
        {
            get { return this.varsta; }
            set
            {
                if (value > 0)
                {
                    this.varsta = value;
                }
            }
        }

        public string Nume
        {
            get { return this.nume; }
            set
            {
                if (value != null)
                {
                    this.nume = value;
                }
            }
        }

        public int[] Note
        {
            get { return this.note; }
            set
            {
                if (value != null)
                {
                    this.note = value;
                }
            }
        }

        public float calculareMedie()
        {
            if (note != null)
            {
                int suma = 0;
                for (int i = 0; i < note.Length; i++)
                {
                    suma += note[i];
                }
                return (float)suma / note.Length;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            string rezultat = base.ToString();
            rezultat += " si numele " + nume + " are varsta " + varsta;

            if (note != null)
            {
                rezultat += " si notele: ";
                for (int i = 0; i < note.Length; i++)
                {
                    rezultat += note[i] + ", ";
                }
            }
            else
            {
                rezultat += " si nu are note";
            }
            return rezultat;

        }

        public object Clone()
        {
            Student clona = (Student)this.MemberwiseClone();
            int[] noteClona = (int[])note.Clone();
            clona.note = noteClona;

            return clona;
        }

        public int CompareTo(object obj)
        {
            Student stud = (Student)obj;

            if(this.medie < stud.medie)
            {
                return -1;
            }
            else
            {
                if(this.medie > stud.medie)
                {
                    return 1;
                }
                else
                {
                    return string.Compare(this.nume, stud.nume);
                }
            }


            return 0;
        }
    }
}
    

