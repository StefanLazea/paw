using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student : Persoana, ICloneable, IComparable, IMedia
    {
        private int varsta;
            private string nume;
            private float medie;
            private int[] note;

        public Student()
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
            note = null;
        }

        public Student(int c,char s, int v, string n, float m, int[] nt) : base (c,s)
        {
            varsta = v;
            nume = n;
            medie = m;
            note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
            {
                note[i] = nt[i];
            }
        }
        public override string ToString()
        {
            string rezultat = base.ToString();
            rezultat += ", numele " + nume + " are varsta " + varsta + ", media " + medie;
            if (note != null)
            {
                rezultat += " si urmatoarele note: ";
                for (int i = 0; i < note.Length; i++)
                {
                    rezultat += note[i] + ", ";
                }
            }
            else
                rezultat += " si nu are note ";

            return rezultat;
        }

        public object Clone()
        {
            Student clona = (Student)this.MemberwiseClone();
            int[] noteNoi = (int[])note.Clone();
            clona.note = noteNoi;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.medie < s.medie)
                return -1;
            else if (this.medie > s.medie)
                return 1;
            else
                return string.Compare(this.nume, s.nume);
        }

        public float calculeazaMedie()
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
                return 0;
        }

        public float Medie
        {
            get { return medie; }
            set{
                if (value > 0)
                    medie = value;
                }
        }

        public int[] Note
        {
            get { return note; }
            set
            {
                if (value != null)
                    note = value;
            }
        }

        public static Student operator+(Student s, int nota)
        {
            int[] noteNoi = new int[s.note.Length + 1];
            for (int i=0;i<s.note.Length; i++)
            {
                noteNoi[i] = s.note[i];
            }
            noteNoi[noteNoi.Length - 1] = nota;
            s.note = noteNoi;
            return s;
        }

        public static Student operator ++ (Student s)
        {
            return s + 1; // adauga nota 1;
        }

        public static explicit operator float(Student s)
        {
            if (s.note != null)
            {
                int suma = 0;
                for (int i = 0; i < s.note.Length; i++)
                {
                    suma += s.note[i];
                }
                return (float)suma / s.note.Length;
            }
            else
                return 0;
        }

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                else return 0;
            }
            set
            {
                if (value > 0)
                    note[index] = value;
            }
        }
    }
}

