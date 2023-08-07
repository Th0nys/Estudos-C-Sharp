using ExercicioClasse4; // Importa o namespace ExercicioClasse4 para utilizar a classe Funcionario.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(); // Cria uma instância da classe Funcionario e atribui à variável 'funcionario'.

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine(); // Lê o nome do funcionário inserido pelo usuário.
            Console.Write("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine()); // Lê o salário bruto do funcionário inserido pelo usuário.
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine()); // Lê o valor do imposto inserido pelo usuário.

            Console.WriteLine();
            Console.WriteLine($"{funcionario}"); // Chama o método 'ToString()' sobrescrito para exibir as informações do funcionário.

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar salario: ");
            double porcentagem = double.Parse(Console.ReadLine()); // Lê a porcentagem de aumento inserida pelo usuário.
            funcionario.AumentarSalario(porcentagem); // Chama o método para aumentar o salário do funcionário.

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {funcionario}"); // Exibe os dados atualizados do funcionário.
        }
    }
}
