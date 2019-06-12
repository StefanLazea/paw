using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class Profesor : IPremiere
    {
        private int marca;
        private string nume;
        private double salariu;

        public int Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public Profesor(int marca, string nume, double salariu)
        {
            this.marca = marca;
            this.nume = nume;
            this.salariu = salariu;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public double Salariu
        {
            get { return this.salariu; }
            set { this.salariu = value; }
        }

        public void Premiaza()
        {
            this.salariu += this.salariu * 0.3;
        }

        public override string ToString()
        {
            return "profesorul cu marca " + this.marca + " cu numele " + this.nume + " are un salariu de  " + this.salariu;
        }

        public static double operator +(double val, Profesor p)
        {
            return p.salariu + val;
        }
    }

}
