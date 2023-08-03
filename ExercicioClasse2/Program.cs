using ExercicioClasse2;
using System;

/* EXERCÍCIO 02:
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            func1.name = Console.ReadLine();
            Console.Write("salario: ");
            func1.wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            func2.name = Console.ReadLine();
            Console.Write("salario: ");
            func2.wage = double.Parse(Console.ReadLine());

            double middle;
            middle = (func1.wage + func2.wage) / 2;
            Console.WriteLine($"Salario Medio = {middle.ToString("F2")}");
        }
    }
}