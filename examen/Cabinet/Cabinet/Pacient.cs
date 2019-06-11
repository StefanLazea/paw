using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet
{
    public class Pacient
    {
        private int idPacient;
        private string nume;
        private int idMedic;
        private string data;
        private string ora;

        public Pacient(int idPacient, string nume, int idMedic, string data, string ora)
        {
            this.idPacient = idPacient;
            this.nume = nume;
            this.idMedic = idMedic;
            this.data = data;
            this.ora = ora;
        }


        public int IdPacient
        {
            get { return this.idPacient; }
            set { this.idPacient = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public int IdMedic
        {
            get { return this.idMedic; }
            set
            {
                this.idMedic = value;
            }
        }

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string Ora
        {
            get { return this.ora; }
            set { this.ora = value; }
        }

        public override string ToString()
        {
            return this.idPacient + "," + this.nume + "," + this.IdMedic + "," + this.data + "," + this.ora;
        }


    }
}
