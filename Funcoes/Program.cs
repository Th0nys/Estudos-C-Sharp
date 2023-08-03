using System;
using System.ComponentModel;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Maior(n1, n2, n3));
        }

        static int Maior(int x, int y, int z)
        {
            int m;

            if (x > y && x > z)
            {
                m = x;
            }
            else if (y > z && y > x) 
            {
                m = y;
            }
            else
            {
                m = z;
            }
            return m;
        }
    }
}