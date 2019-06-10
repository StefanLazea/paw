using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4
{
   public class Student:Persoana, ICloneable, IComparable, IMedia //fac clasa student publica, sa poata fi accesata in form si la fel si persoana
    {
        private int varsta;
        private string nume;
        private float medie;
        
        private int[] note;

        public Student():base()
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
            note = null;
        }

        public Student(int v, string n, float m, int[] nt, int c, char s):base(c,s)
        {
            varsta = v;
            nume = n;
            medie = m;
            //deep copy
            note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];
        }

        public override string ToString()
        {
            string rezultat = base.ToString();
            rezultat += " si numele " + nume + " are varsta " + varsta + " media " + medie;
            if (note != null)
            {
                rezultat += " si urmatoarele note: ";
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + ", ";
            }
            else rezultat += " si nu are note";
            return rezultat;
        }

        //proprietati
        public float Medie
        {
            get { return medie; }
            set{ if (value>0)
                medie=value;}
        }

        public int[]Note
        {
            get{return note;}
            set{if(value!=null)
                note=value;
            }
        }//prin asta se modif tot vectorul
        //doar cand avem tipuri primitive folosim memberwiseclone, altfel facem o copie
        public object Clone()
        {   Student clona=(Student)this.MemberwiseClone();
            int[]noteNoi=(int[])note.Clone(); //metoda clone se putea implementa si in constructorul cu parametrii
            clona.note=noteNoi; //vectorul note aferent studentului clona refera noul vector creat
            return clona; //returneaza obiect

        }

        //CompareTo defineste doar criteriul de comparatie; doar Sort il foloseste
        public int CompareTo(object obj)
        {   Student s=(Student) obj; //cast la obiect mereu(transformam obj in Student)
            //criteriu:dupa medie
            if(this.medie<s.medie)
                return -1;
            else
                if(this.medie>s.medie)
                    return 1;
                else return string.Compare(this.nume, s.nume); //comparam dupa nume(comparare string uri de caractere)	
        }
        /*supraincarcari(functie prin care dam semnificatie operatorilor) de operatori
        * se face explicit
        * index se supraincarca doar in clasele cu vectori/colectii
        * supraincarcare de + */

        public static Student operator +(Student s, int nota)
        {
            int [] noteNoi=new int[s.note.Length+1]; //fac vector nou cu o pozitie in plus pt nota care se adauga
            for(int i=0;i<s.note.Length;i++)
                noteNoi[i]=s.note[i]; //copiez notele din note in vectorul noteNoi
            noteNoi[noteNoi.Length-1]=nota; //pe ultima pozitie pun noua nota
            s.note=noteNoi; //schimb referinta ca se refere adresa noul vector
            return s;

        }

        public static Student operator ++(Student s)
        {
            return s+1; //apelam op anterior in care nota=1; trb implementat si operatorul + obligatoriu ca sa l apeleze
        }
        //supraincarcare cast

        public static explicit operator float(Student s)
        {   if(s.note!=null)
            {int suma=0;
            for(int i=0;i<s.note.Length;i++)
                suma+=s.note[i];
            return (float)suma/s.note.Length;}
        else
            return 0;
        }
        //fara static ca e proprietate; operator index
        public int this[int index]
        {
            get
            {
                if(note!=null && index>=0 && index<note.Length)
                    return note[index];
                else
                    return 0;
            }

            set
            { if(value>0)
                note[index]=value;
        }//prin asta se modif un element din vector
        }

        public float calculeazaMedia(){
            if (note!=null)
            {
            int suma=0;
            for(int i=0;i<note.Length;i++)
                suma+=note[i];
            return (float)suma/note.Length;
            }
        else
            return 0;
        }

        }
    }

