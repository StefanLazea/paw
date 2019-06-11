using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitateTuristica
{
    [Serializable]
    public class Hotel
    {
        private List<Camera> listaCamere;

        public Hotel(List<Camera> listaCamere) 
        {
            this.listaCamere = listaCamere;
        }

        public Hotel(string filename)
        {
            String[] lini = File.ReadAllLines(filename);

            this.listaCamere = new List<Camera>();
            for(int i = 0; i < lini.Length; i=i+4)
            {
                Camera c = new Camera(Convert.ToInt32(lini[i]), lini[i + 1], Convert.ToBoolean(lini[i + 2]), lini[i + 3]);
                this.listaCamere.Add(c);
            }
        }

        public List<Camera> ListaCamera
        {
            get { return this.listaCamere; }
            set { this.listaCamere = value; }
        }

        public static Hotel operator +(Hotel hotel, Camera c)
        {
            hotel.listaCamere.Add(c);
            return hotel;
        }

        public static bool operator >(Hotel c1, Hotel c2)
        {
            if(c1.listaCamere.Count > c2.listaCamere.Count)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Hotel c1, Hotel c2)
        {
            if (c1.listaCamere.Count < c2.listaCamere.Count)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            String result = "Unitatea turistica are " + this.listaCamere.Count + " camere, de tipul:\r\n";
            foreach(Camera c in this.listaCamere)
            {
                result += c.ToString() + "\r\n";
            }

            return result;
        }
    }
}
