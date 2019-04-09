using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar2
{
    class Program
    {
        static void Main()
        {
            Animal a1 = new Animal(2, "Azorel", 0.0f);
            Animal a2 = new Animal();
            a2.Varsta = 3;
            a2.Nume = "Azorel";
            a2.Greutate = 6.7f;
            Console.WriteLine(a1.Nume); //primeste ca parametru string, afiseaza automat
            Console.WriteLine("Animalul {0} are varsta {1}", a1.Nume, a1.Varsta);

            Console.WriteLine(a1); //trb sa fac override in clasa Animal ca sa stie ce sa afiseze la acest apel
            Console.WriteLine(a2);

            Cal cal1 = new Cal(12, "Gigel", 100, 100, true);
            Caine c1 = new Caine(2, "Juju", 12, "bej", false);

            Console.WriteLine(c1); //afisare tot despre Juju

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(cal1);
            z1.ListaAnimale.Add(c1);
            z1.ListaAnimale.Sort(); //sort apeleaza implicit COMPARE TO din Animal=> sortate dupa varsta, si daca au aceeasi varsta, sortate dupa nume

            Console.WriteLine(z1); //apeleaza overrideul din Zoo

            Zoo z2 = (Zoo)z1.Clone(); //deep copy=copiere de continut intre cele 2
           
            z2.Denumire = "Zoo Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume+=" copie"; //la numele fiecarui animal din z2 care va fi la fel ca cele din z1 concatenam "copie" ca sa stim ca nu s aceleasi
            Console.WriteLine(z1);
            Console.WriteLine(z2);




        }
    }
}
