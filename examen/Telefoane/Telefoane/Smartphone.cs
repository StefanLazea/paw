using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoane
{
    [Serializable]
    public class Smartphone: IComparable
    {
        private int id;
        private string model;
        private int stocDisp;
        private float pret;
        private string dataAparitie;
        private int idProducator;

        public Smartphone(int id, string model, int stocDisp, float pret, string dataAparitie, int idProducator)
        {
            this.id = id;
            this.model = model;
            this.stocDisp = stocDisp;
            this.pret = pret;
            this.dataAparitie = dataAparitie;
            this.idProducator = idProducator;
        }

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int StocDisp
        {
            get { return this.stocDisp; }
            set
            {
                this.stocDisp = value;
            }
        }
        public float Pret
        {
            get { return this.pret; }
            set { this.pret = value;}
        }
        public string DataAparitie
        {
            get { return this.dataAparitie; }
            set { this.dataAparitie = value; }
        }

        public int IdProducator
        {
            get { return this.idProducator; }
            set { this.idProducator = value; }
        }

        public int CompareTo(object obj)
        {
            Smartphone telefon = (Smartphone)obj;

            if(this.pret > telefon.pret && this.stocDisp < telefon.stocDisp)
            {
                return -1;
            }else if(this.pret < telefon.pret && this.stocDisp > telefon.stocDisp)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return "Telefonul cu id-ul: " + this.id + " este un " + this.model + " si costa " + this.pret
                + " fiind lansat de " + this.idProducator + " la data " + this.dataAparitie;
        }
        
        public static explicit operator int(Smartphone s)
        {
            return s.stocDisp;
        }
    }
}
