using ExercicioDeFixacaoEmcapsulamento;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o numero da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(id, nome, depoInicial);
            }
            else{
                conta = new Conta(id, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre o valor do deposito: ");
            double depo = double.Parse(Console.ReadLine());
            conta.Deposito(depo);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}