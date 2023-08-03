using ClassesPt2;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 900.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2"));
            Console.WriteLine(p.Quantidade);
            
        }
    }
}