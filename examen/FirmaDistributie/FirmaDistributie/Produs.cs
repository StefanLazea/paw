using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDistributie
{
    public class Produs: IComparable
    {
        private int id;
        private string nume;
        private int unitati;
        private decimal pret;
        private int idFurnizor;

        public Produs(int id, string nume, int unitati, decimal pret, int idFurnizor)
        {
            this.id = id;
            this.nume = nume;
            this.unitati = unitati;
            this.pret = pret;
            this.idFurnizor = idFurnizor;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public int Unitati
        {
            get { return this.unitati; }
            set { this.unitati = value; }
        }

        public decimal Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public int IdFurnizor
        {
            get { return this.idFurnizor; }
            set { this.idFurnizor = value; }
        }

        public int CompareTo(object obj)
        {
            Produs p = (Produs)obj;
            if(this.pret > p.pret)
            {
                return 1;
            }else if(this.pret < p.pret)
            {
                return -1;
            }
            return 0;
        }

        public static explicit operator decimal(Produs p)
        {
            return p.pret * p.unitati;
        }
    }
}
