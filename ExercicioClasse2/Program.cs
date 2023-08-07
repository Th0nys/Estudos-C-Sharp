using ExercicioClasse2; // Importa o namespace ExercicioClasse2 para utilizar a classe Funcionario.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario(); // Cria uma instância da classe Funcionario e atribui à variável func1.
            Funcionario func2 = new Funcionario(); // Cria outra instância da classe Funcionario e atribui à variável func2.

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            func1.name = Console.ReadLine(); // Atribui o nome do primeiro funcionário.
            Console.Write("Salario: ");
            func1.wage = double.Parse(Console.ReadLine()); // Atribui o salário do primeiro funcionário.

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            func2.name = Console.ReadLine(); // Atribui o nome do segundo funcionário.
            Console.Write("Salario: ");
            func2.wage = double.Parse(Console.ReadLine()); // Atribui o salário do segundo funcionário.

            double middle;
            middle = (func1.wage + func2.wage) / 2; // Calcula o salário médio dos funcionários.
            Console.WriteLine($"Salario Medio = {middle.ToString("F2")}"); // Exibe o salário médio formatado com duas casas decimais.
        }
    }
}
