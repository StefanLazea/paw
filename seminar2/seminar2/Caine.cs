using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Caine:Animal
    {
        private string culoare;
        private bool mushca;

        public Caine()
            : base()
        {
            culoare = "alb";
            mushca = true;
        }

        public Caine(int v, string n, float g, string c, bool m)
            : base(v, n, g)
        {
            culoare = c;
            mushca = m;
        }

        public override string ToString()
        {
            return base.ToString()+" are culoarea "+culoare+" si mushca: "+mushca;
        }
    }
}
