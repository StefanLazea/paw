using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_mod
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoturism a = new Autoturism(30, "mercedes", new float[3] { 10, 6, 7 }, 4, "benzina");
            Console.WriteLine(a.calculareConsumMediu());
            Console.WriteLine((float)a);

            //shallow copy
            Autoturism b = a;
            Console.WriteLine(b.ToString());
            Console.WriteLine(a.ToString());

            a.Marca = "BMW";
            Console.WriteLine(b.ToString());
            Console.WriteLine(a.ToString());

            Autoturism c = (Autoturism) a.Clone();
            Console.WriteLine("deep-copy: inainte:");
            Console.WriteLine(c.ToString());
            Console.WriteLine(a.ToString());
            a.Marca = "Audi";
            Console.WriteLine("deep-copy: dupa:");
            Console.WriteLine(c.ToString());
            Console.WriteLine(a.ToString());
        }
    }
}
