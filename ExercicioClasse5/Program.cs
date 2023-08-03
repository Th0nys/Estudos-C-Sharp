using ExercicioClasse5;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine());
            aluno.NotaB = double.Parse(Console.ReadLine());
            aluno.NotaC = double.Parse(Console.ReadLine());
            Console.WriteLine($"{aluno}");
        }
    }
}
