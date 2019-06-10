using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoane
{
    public class Smartphone
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
            set { this.IdProducator = value; }
        }
    }
}
