using ExercicioClasse5; // Importa o namespace ExercicioClasse5 para utilizar a classe Aluno.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno(); // Cria uma instância da classe Aluno e atribui à variável 'aluno'.

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine(); // Lê o nome do aluno inserido pelo usuário.
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine()); // Lê a primeira nota inserida pelo usuário.
            aluno.NotaB = double.Parse(Console.ReadLine()); // Lê a segunda nota inserida pelo usuário.
            aluno.NotaC = double.Parse(Console.ReadLine()); // Lê a terceira nota inserida pelo usuário.
            Console.WriteLine($"{aluno}"); // Chama o método 'ToString()' sobrescrito para exibir as informações do aluno.
        }
    }
}
