using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Masina masina = new Masina("benzina",12000,90);
            Console.WriteLine("masina cu combustibilul {0} costa {1}", masina.Motorizare, masina.Pret);
        }
    }
}
