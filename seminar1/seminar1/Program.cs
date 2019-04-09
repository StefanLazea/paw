using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Numele este {0}", nume);

            //declarare vector
            int[] v1 = new int[3]; //declarare vector cu 3 elem initializate cu 0 by default
            Console.Write("V1 contine elementele: ");
            for (int i = 0; i < v1.Length; i++) 
            {   Console.Write("{0}", v1[i]); //afisare vector v1 pe mai multe linii
             Console.WriteLine();
            }//linie noua

            int[] v2;
            v2 = new int[4] { 10, 20, 30, 40 }; //decl vector si ii dau si valori sa nu mai fie 0 by default
            int [] v3={1,2,3,4}; //declarare vector
            Console.Write("V2 contine elementele: ");
            for(int i=0; i<v2.Length;i++)
                Console.Write("{0} ", v2[i]); //afisare v2 pe o singura linie

            int[] v4 = v2; //shallow copy; v4 se incarca cu val lui v2, dar daca v2 se modifica, v4 se modif si el
            v2[1] = 500;
            Console.WriteLine();
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]); //afisare noul v2
            Console.WriteLine();
            for (int i = 0; i < v4.Length; i++)
                Console.Write("{0} ", v4[i]); //afisare v4 care s a modificat la fel ca v2

            //deep copy; daca se modif v2, v5 si v6 nu se modifica
            //prima varianta: element cu element
            int[] v5 = new int[4];
            for (int i = 0; i < v2.Length; i++)
                v5[i] = v2[i];
            //a doua varianta
            int[] v6 = (int[])v2.Clone(); //folosind metoda clone

            //declarare matrice
            int[,] mat1=new int[2,3] {{10,20,30}, {40,50,60}};
            for(int i=0;i<mat1.GetLength(0);i++) //getlength(0) ia primul numar, adica nr de linii
            {for(int j=0;j<mat1.GetLength(1);j++)
                Console.Write("{0} ", mat1[i, j]);
            Console.WriteLine();
            } //afisare matrice mat1

            //declarare matrice jagged(zig-zag); cand nu stim nr de linii/coloane
            int[][] mat2 = new int[3][];
            mat2[0] = new int[2] { 10, 20 };
            mat2[1] = new int[3] { 30, 40, 50 };
            mat2[2] = new int[4] { 60, 70, 80, 90 };
            for (int i = 0; i < mat2.Length; i++)
            {
                for (int j = 0; j < mat2.Length; j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            } //afisare




        }
    }
}
