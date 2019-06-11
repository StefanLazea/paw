using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet
{
    public class Medic
    {
        private int idMedic;
        private string specializare;
        private int tarif;

        public Medic(int idMedic, string specializare, int tarif)
        {
            this.idMedic = idMedic;
            this.specializare = specializare;
            this.tarif = tarif;
        }

        public int IdMedic
        {
            get { return this.idMedic; }
            set { this.idMedic = value; }
        }

        public string Specializare
        {
            get { return this.specializare; }
            set { this.specializare = value; }
        }

        public int Tarif
        {
            get { return this.tarif; }
            set { this.tarif = value; }
        }
    }
}
