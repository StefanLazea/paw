using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Cal:Animal //mosteneste nume, varsta, greutate
    {
        private int viteza;
        private bool estePotcovit;

        public Cal():base()//apel constructor implicit din clasa Animal
        {
            viteza = 0;
            estePotcovit = true;
        }

        public Cal(int v, string n, float g, int vit, bool ep):base(v,n,g)
        {
            viteza=vit;
            estePotcovit=ep;
        }
        public override string ToString()
        {
            return base.ToString()+" si viteza "+viteza+" si este potcovit: "+estePotcovit;
        } //aici pastram base.tostring sa afiseze ce e in clasa animal la care concatenam celelalte atribute


       
    }
}
