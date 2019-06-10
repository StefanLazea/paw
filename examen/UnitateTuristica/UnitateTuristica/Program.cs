using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitateTuristica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Camera c1 = new Camera(7, "single", false, "25.10.2019");
            Camera c2 = new Camera(8, "double", true, "25.10.2019");
            Camera c3 = new Camera(9, "tripla", false, "25.10.2019");
            Camera c4 = new Camera(10, "single", true, "25.10.2019");
            Camera c5 = new Camera(11, "tripla", true, "25.10.2019");
            Camera c6 = new Camera(12, "single", true, "25.10.2019");

            List<Camera> listaCamere = new List<Camera>();
            listaCamere.Add(c1);
            listaCamere.Add(c2);
            listaCamere.Add(c3);
            listaCamere.Add(c4);

            Hotel hotel1 = new Hotel(listaCamere);
            Console.WriteLine(hotel1.ToString());

            Console.WriteLine("utilizare operator +");

            Camera c7 = new Camera(13, "single", false, "25.10.2019");
            hotel1 += c7;

            Console.WriteLine(hotel1.ToString());


            Console.WriteLine("utilizare operator >");

            List<Camera> listaCamere2 = new List<Camera>();
            listaCamere2.Add(c1);
            listaCamere2.Add(c2);
            Hotel hotel2 = new Hotel(listaCamere2);
            Console.WriteLine("Are a doua unitate mai multe camere decat prima? {0}", hotel2 > hotel1);

            Console.WriteLine("initializare din fisier");

            Hotel hotel3 = new Hotel("camere.txt");
            Console.WriteLine(hotel3.ToString());




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(hotel3.ListaCamera));
        }
    }
}
