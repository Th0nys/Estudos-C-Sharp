using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco eh $ {preco1}\n{produto2}, cujo preco eh $ {preco2}\n");
            Console.WriteLine($"registro: {idade} anos de idade, codigo {codigo} e genero: {genero}\n");
            Console.WriteLine($"Media com oito casas decimais: {media:F8}\nArredondado(tres casas decimais): {media:F3}" +
                $"\nSeparador de decimal invariant culture: {media.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}