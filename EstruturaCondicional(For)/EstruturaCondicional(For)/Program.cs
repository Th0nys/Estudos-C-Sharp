using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1;  i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                sum += valor;
            }
            Console.WriteLine($"Soma = {sum}");
        }
    }
}
