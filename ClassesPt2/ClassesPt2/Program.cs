using ClassesPt2; // Importa o namespace ClassesPt2 para utilizar a classe Produto.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 900.00, 10); // Cria uma instância de Produto com nome "Tv", preço 900.00 e quantidade 10.

            p.Nome = "T"; // Define o nome do produto para "T" (aplica validação no setter da propriedade Nome).

            Console.WriteLine(p.Nome); // Imprime o nome do produto ("T").
            Console.WriteLine(p.Preco.ToString("F2")); // Imprime o preço do produto formatado com duas casas decimais (900.00).
            Console.WriteLine(p.Quantidade); // Imprime a quantidade em estoque do produto (10).
        }
    }
}
