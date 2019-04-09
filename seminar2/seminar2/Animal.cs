using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Animal:ICloneable,IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;

        public Animal()
        {
            varsta = 0;
            nume = "Anonim";
            greutate = 0.0f;
        }//constructor implicit(initializeaza atributele clasei

        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }//constructor cu parametrii


        //proprietatile(get si set) !!!nu e functie, e vazuta ca atribut al clasei
        public int Varsta
        {
            get { return varsta; }
            set
            {
                if (value >0)
                    varsta = value;
            }
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null) //cond pt stringuri
                    nume=value;
            }
        }

        public float Greutate
        {
            get
            {
                return greutate;
            }
            set
            {
                if (value > 0)
                    value = greutate;
            }
        }
 //override=supradefinire, se fol pt afisare; 
 //este o metoda ce RETURNEAZA un string;
//base=cuvant cheie care semnifica apelul clasei de baza; folosit in clasele derivate pt a apela si ce e in functia override din clasa de baza
        public override string ToString()
        {
            //return base.ToString();//asta ne ajuta atunci cand vom deriva clasa animal
            return "Animalul " + nume + " are varsta " + varsta + " si greutatea " + greutate; //asta vr sa mi afiseze cand dau afisare de a1
        }




        public object Clone()
        {
            return this.MemberwiseClone(); //face shallow copy=copiere de adrese intre doua obiecte
        }

        public int CompareTo(object obj)
        {
            Animal a = (Animal)obj; //downcast=transformare din tip generic in tip object;un animal a random cu care sa putem compara; a o sa fie gen a1, a2, depinde
            if (this.varsta < a.varsta) //this.varsta=atributul varsta al obiectului curent al clasei
                return -1;
            else
                if (this.varsta > a.varsta)
                    return 1;
                else
                    return string.Compare(this.nume, a.nume); //daca varstele sunt egale, comparam dupa nume
        }
        //METODA COMPARE TO POATE RETURNA 3 VALORI
        //if ....<.... return -1;
        // else
             //if....>... return 1;
             //else 
              //return 0; (adica atunci cand sunt egale





    }
}
