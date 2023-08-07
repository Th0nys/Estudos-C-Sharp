using ExercicioDeFixacaoEmcapsulamento; // Importa o namespace ExercicioDeFixacaoEmcapsulamento para utilizar a classe Conta.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta; // Declaração da variável para armazenar a instância de Conta.

            Console.Write("Entre o numero da conta: ");
            int id = int.Parse(Console.ReadLine()); // Lê o número da conta inserido pelo usuário.

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine(); // Lê o nome do titular inserido pelo usuário.

            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine()); // Lê a resposta do usuário sobre o depósito inicial.

            Console.WriteLine();

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depoInicial = double.Parse(Console.ReadLine()); // Lê o valor do depósito inicial inserido pelo usuário.
                conta = new Conta(id, nome, depoInicial); // Cria uma instância de Conta com depósito inicial.
            }
            else
            {
                conta = new Conta(id, nome); // Cria uma instância de Conta sem depósito inicial.
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta); // Chama o método 'ToString()' sobrescrito para exibir os dados da conta.
            Console.WriteLine();

            Console.Write("Entre o valor do deposito: ");
            double depo = double.Parse(Console.ReadLine()); // Lê o valor do depósito inserido pelo usuário.
            conta.Deposito(depo); // Realiza o depósito na conta.

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta); // Exibe os dados atualizados da conta.
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine()); // Lê o valor do saque inserido pelo usuário.
            conta.Saque(saque); // Realiza o saque na conta.

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta); // Exibe os dados atualizados da conta.
        }
    }
}
