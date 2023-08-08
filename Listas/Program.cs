using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Thony");
            list.Add("Leticia");
            list.Add("Leandro");
            list.Add("Cristofer");
            list.Insert(0, "Matheus");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'L');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'L');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'L');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine(pos2);

            List<String> list2 = list.FindAll(x => x.Length == 7);
            Console.WriteLine("------------------");
            foreach(string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------");
            list.Remove("Leticia");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------");
            list.RemoveAt(2);

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------");
            list.RemoveRange(0, 1);

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}