using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cristi2
{
    public class Camera
    {
        public int numar;
        public string tipCamera;
        public float pret;

        public Camera(){
        
        }
        public Camera(int numar, string tipCamera, float pret)
        {
            this.numar = numar;
            this.tipCamera = tipCamera;
            this.pret = pret;
        }
    }
}
