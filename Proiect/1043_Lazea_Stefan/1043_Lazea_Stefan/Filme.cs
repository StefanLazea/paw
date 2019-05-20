﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043_Lazea_Stefan
{
    class Filme: ICloneable, IComparable
    {
        private int id;
        private string denumire;
        private string gen;
        private DateTime dataLansare;
        private double durata;
        private float pretInchiriere;

        public Filme()
        {

        }

        public Filme(
            int id,
            string denumire,
            string gen, 
            DateTime dataLansare, 
            double durata, 
            float pretInchiriere
         ) {
            this.id = id;
            this.denumire = denumire;
            this.gen = gen;
            this.dataLansare = dataLansare;
            this.durata = durata;
            this.pretInchiriere = pretInchiriere;
        }
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }

        public string Gen
        {
            get { return this.gen; }
            set { this.gen = value; }
        }

        public DateTime Datalansare
        {
            get { return this.dataLansare; }
            set { this.dataLansare = value; }
        }

        public double Durata
        {
            get { return this.durata; }
            set { this.durata = value; }
        }


        public float PretInchiriere
        {
            get { return this.pretInchiriere; }
            set { this.pretInchiriere = value; }
        }

        public object Clone()
        {
            Filme f = (Filme)this.MemberwiseClone();

            return f;
        }

        public int CompareTo(object obj)
        {
            Filme f = (Filme)obj;
            if(this.pretInchiriere < f.pretInchiriere)
            {
                return -1;
            }else if(this.pretInchiriere == f.pretInchiriere)
            {
                return 1;
            }
            else
            {
                return string.Compare(this.denumire, f.denumire);
            }
        }

        public override string ToString()
        {
            return "Filmul " + this.denumire + " lansat in " + this.dataLansare.ToString() + " are un pret de inchiriere de " + this.pretInchiriere +
                " lei si are o durata de " + this.durata + "\n";
        }

    }
}
