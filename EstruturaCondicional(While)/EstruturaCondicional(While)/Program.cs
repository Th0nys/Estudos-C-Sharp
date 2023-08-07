using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine()); // Lê o número inserido pelo usuário.

            // Loop que continua enquanto o número inserido for não negativo.
            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x); // Calcula a raiz quadrada do número inserido.
                Console.WriteLine(raiz.ToString("F3")); // Exibe a raiz quadrada com três casas decimais.
                Console.Write("Digite outro numero: "); // Solicita ao usuário para inserir outro número.
                x = double.Parse(Console.ReadLine()); // Lê o novo número inserido.
            }

            Console.WriteLine("Numero Negativo!"); // Exibe essa mensagem quando um número negativo for inserido.
        }
    }
}
