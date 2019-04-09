using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina masina = new Masina("benzina", 30000, 295);
            Console.WriteLine("avem {0} cu cp {1}", masina.Motorizare, masina.Putere);

            Masina masina2 = new Masina();
            masina2.Putere = 300;
            masina2.Motorizare = "electric";
            Console.WriteLine(masina2); //daca nu am fi avut toString override nu ar fi aratat decat namespace + clasa

            Decapotabila n = new Decapotabila("benzina", 200000, 290, 200, 4);
            Console.WriteLine(n);

            Parc pc = new Parc();
            pc.ListaMasini.Add(masina);
            pc.ListaMasini.Add(masina2);

            pc.ListaMasini.Sort();

            Console.Write(pc);
            Parc p2 = (Parc)pc.Clone();

            foreach(Masina m in p2.ListaMasini)
            {
                m.Motorizare += " impozit mare";
            }
            Console.WriteLine(p2);
        }
    }
}
