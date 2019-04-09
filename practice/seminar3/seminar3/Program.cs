using System;
using System.Collections.Generic;

namespace seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(100, 'M', 20, "Mihnea", 3.4f, new int[3] { 3, 4, 5 });
            Student s1 = new Student(89, 'F', 20, "Mihnea", 3.4f, new int[3] { 1, 7, 5 });
            Student s3 = new Student(90, 'M', 25, "Mihai", 9.4f, new int[3] { 9, 8, 10 });

            Console.WriteLine(s1);
            //cast explicit la float, returneaza media
            s1.Medie = (float)s1;
            Console.WriteLine("media este {0}", s1.Medie);

            //Student s2 = s3; shallow copy
            Student s2 = (Student)s3.Clone();
            Console.WriteLine(s2.ToString());
            s3 += 10; //adaug nota 10 studentului 3
            s3++; //adaug nota 1
            s3.Medie = (float)s3; //actualizam media
            Console.WriteLine(s3);
            Console.WriteLine("Cea de a doua nota a lui s3 este {0}", s3[1]);
            s3[4] = 5;
            Console.WriteLine(s3);

            Console.WriteLine("---------------");
            List<Student> listaStudenti = new List<Student>();
            listaStudenti.Add(s);
            listaStudenti.Add(s1);
            listaStudenti.Add(s2);
            listaStudenti.Add(s3);

            foreach(Student t in listaStudenti)
            {
                Console.WriteLine(t);
            }
            listaStudenti.Sort();

            foreach(Student t in listaStudenti)
            {
                Console.WriteLine(t);
            }
            
        }
    }
}
