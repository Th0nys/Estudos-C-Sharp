using System;
using VetoresPt2;

/* Fazer um programa para ler um numero inteiro N e os dados (nome e preco)
 * de N produtos. Armazene os N produtos em um vetor. Em seguida, mostrar o preco medio
 * dos produtos*/

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;

            for (int i = 0;i < n;i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"Preco Medio: {avg.ToString("F2")}");
        }
    }
}
