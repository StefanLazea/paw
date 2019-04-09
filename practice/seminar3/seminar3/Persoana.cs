using System;
using System.Collections.Generic;
using System.Text;

namespace seminar3
{
    abstract class Persoana
    {
        int cod;
        char sex;

        public Persoana()
        {
            this.cod = 0;
            this.sex = 'M';
        }

        public Persoana(int cod, char sex)
        {
            this.cod = cod;
            this.sex = sex;
        }

        public override string ToString()
        {
            return "persoana este de sex " + this.sex + " si are codul " + this.cod;
        }
    }
}
