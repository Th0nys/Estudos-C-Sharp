using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário para inserir seu nome completo e armazena na variável 'nome'.
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            // Solicita ao usuário para inserir a quantidade de quartos na casa e armazena em 'quartos'.
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            // Solicita ao usuário para inserir o preço de um produto e armazena em 'produto'.
            Console.WriteLine("Entre com o preco de um produto:");
            double produto = double.Parse(Console.ReadLine());

            // Solicita ao usuário para inserir o último nome, idade e altura, e armazena em 'dados'.
            Console.WriteLine("Entre com seu ultimo nome, idade e altura(mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');

            // Exibe as informações coletadas anteriormente.
            Console.WriteLine($"{nome}\n{quartos}\n{produto}\n{dados[0]}\n{dados[1]}\n{dados[2]}");
        }
    }
}
