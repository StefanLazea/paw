using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<Medic> medici = new List<Medic>();
            Medic m1 = new Medic(1, "cardiologie", 100);
            Medic m2 = new Medic(2, "orl", 90);
            Medic m3 = new Medic(3, "oftalmologie", 89);
            Medic m4 = new Medic(4, "ginecologie", 200);
            Medic m5 = new Medic(5, "radiologie", 100);

            medici.Add(m1);
            medici.Add(m2);
            medici.Add(m3);
            medici.Add(m4);
            medici.Add(m5);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(medici));
        }
    }
}
