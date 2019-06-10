using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitateTuristica
{
    [Serializable]
    public class Camera: IComparable
    {
        private int nrCamera;
        private string tipCamera;
        private bool esteOcupata;
        private string dataOcupare;

        public Camera(int nrCamera, string tipCamera, bool esteOcupata, string dataOcupare)
        {
            this.nrCamera = nrCamera;
            this.tipCamera = tipCamera;
            this.esteOcupata = esteOcupata;
            this.dataOcupare = dataOcupare;
        }

        public int NrCamera
        {
            get { return this.nrCamera; }
            set { this.nrCamera = value; }
        }

        public string TipCamera
        {
            get { return this.tipCamera; }
            set { this.tipCamera = value; }
        }

        public bool EsteOcupata
        {
            get
            {
                return this.esteOcupata;
            }
            set
            {
                this.esteOcupata = value;
            }
        }

        public string DataOcupare
        {
            get { return this.dataOcupare; }
            set { this.dataOcupare = value; }
        }

        public int CompareTo(object obj)
        {
            Camera c = (Camera)obj;

            if(this.nrCamera > c.nrCamera)
            {
                return 1;
            }
            else
            {
                if(this.nrCamera < c.nrCamera)
                {
                    return -1;
                }
            }
            return 0;

        }

        public override string ToString()
        {
            return "Camera cu numarul " + this.nrCamera + " este de tip "
                 + this.tipCamera + " iar la data de " + this.dataOcupare + " este ocupata " +this.esteOcupata;
        }
    }
}
