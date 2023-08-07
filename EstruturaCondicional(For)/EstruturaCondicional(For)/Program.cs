using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine()); // Lê a quantidade de números a serem inseridos.

            int sum = 0; // Variável para armazenar a soma dos números.

            // Loop que itera N vezes (de acordo com a quantidade de números informada).
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: "); // Solicita ao usuário o valor do número.
                int valor = int.Parse(Console.ReadLine()); // Lê o número.

                sum += valor; // Adiciona o número à soma acumulada.
            }

            Console.WriteLine($"Soma = {sum}"); // Exibe a soma total dos números inseridos.
        }
    }
}
