using ExercicioClasse1;
using System;

/* EXERCÍCIO 01:
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.*/

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person1, person2;
            person1 = new Pessoa();
            person2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.name = Console.ReadLine();
            Console.Write("Idade: ");
            person1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.name = Console.ReadLine();
            Console.Write("Idade: ");
            person2.age = int.Parse(Console.ReadLine());

            if (person1.age > person2.age)
            {
                Console.WriteLine($"Pessoa mais velha: {person1.name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {person2.name}");
            }
            
        }
    }
}
