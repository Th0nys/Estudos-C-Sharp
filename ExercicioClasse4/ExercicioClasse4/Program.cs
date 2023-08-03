using ExercicioClasse4;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{funcionario}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {funcionario}");
        }
    }
}
