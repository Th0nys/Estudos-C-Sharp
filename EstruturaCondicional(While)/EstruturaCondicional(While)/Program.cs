using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"));
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero Negativo!");
        }
    }
}