using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Decapotabila:Masina
    {
        private float vitezaMaximaDecapotata;
        private int numarLocuri;

        public Decapotabila():base()
        {
            this.vitezaMaximaDecapotata = 200;
            this.numarLocuri = 4;
        }

        public Decapotabila(
            string motorizare,
            float pret,
            int putere,
            float vitezaMaxima, 
            int numarLocuri)
            :base(motorizare,pret,putere)
        {
            this.vitezaMaximaDecapotata = vitezaMaxima;
            this.numarLocuri = numarLocuri;
        }

        public override string ToString()
        {
            return base.ToString() + " si poate merge cu " 
                + vitezaMaximaDecapotata + " avand " 
                + numarLocuri + "locuri";
        }
    }
}
