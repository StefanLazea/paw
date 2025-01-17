﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(20, "Gigel", 0.0f, new int[3] { 7, 9, 10 },100, 'M');
            Console.WriteLine(s1);
            s2.Medie = (float)s2; //am apelat setterul pt medie si castul la float care face medie notelor din vector
            Console.WriteLine(s2);
            Student s3 = (Student)s2.Clone();
            s3 += 10; //adaug nota 10 studentului 3
            s3++; //adaug nota 1
            s3.Medie = (float)s3; //actualizam media
            Console.WriteLine(s3);
            Console.WriteLine("Cea de a doua nota a lui s3 este {0}", s3[1]);
            s3[4] = 5;
            Console.WriteLine(s3);

            Console.WriteLine("---------------------------------------------");
            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort(); //apeleaza CompareTo=> afisare in ord crescatoare dupa medie
            
            foreach(Student s in listaStud)
                Console.WriteLine(s);
            for(int i=0;i<listaStud.Count;i++)
                Console.WriteLine(listaStud[i]);
            s3.Medie = s3.calculeazaMedia();
            Console.WriteLine("Media lui s3 este: " + s3.Medie);


            s3.Medie = (float)s3;
            Console.WriteLine("Media lui s3 este: " + s3.Medie);

        }
    }
}
