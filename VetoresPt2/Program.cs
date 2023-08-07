using System;
using VetoresPt2; // Importa o namespace VetoresPt2 para usar a classe Product.

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Lê o número inteiro N, que representa a quantidade de produtos.

            Product[] vect = new Product[n]; // Cria um vetor de objetos Product para armazenar os produtos.

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine(); // Lê o nome do produto.
                double price = double.Parse(Console.ReadLine()); // Lê o preço do produto.

                vect[i] = new Product { Name = name, Price = price }; // Cria um objeto Product com os dados lidos e adiciona ao vetor.
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price; // Calcula a soma dos preços dos produtos.
            }

            double avg = sum / n; // Calcula o preço médio dos produtos.

            Console.WriteLine($"Preco Medio: {avg.ToString("F2")}"); // Exibe o preço médio formatado com duas casas decimais.
        }
    }
}
