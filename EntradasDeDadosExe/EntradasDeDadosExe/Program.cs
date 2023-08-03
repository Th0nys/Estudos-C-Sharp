using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura(mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');
            Console.WriteLine($"{nome}\n{quartos}\n{produto}\n{dados[0]}\n{dados[1]}\n{dados[2]}");
        }
    }
}
