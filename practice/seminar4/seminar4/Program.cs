using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Suv suv = new Suv("murac", 1,new float[1] { 100 },1000000, "4x4");
            //Suv suv2 = (Suv)suv.Clone();
            //suv2.Model = "lambo";
            //Console.WriteLine(suv);
            //Console.WriteLine(suv2);
            //suv2.Pret = (float)suv;
            //Console.WriteLine("pretul masinii 2 este: " + suv2.Pret);

            //suv2 += 1231;
            //Console.WriteLine(suv2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
