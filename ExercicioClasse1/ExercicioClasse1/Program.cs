using ExercicioClasse1; // Importa o namespace ExercicioClasse1 para utilizar a classe Pessoa.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person1, person2; // Declara duas variáveis do tipo Pessoa chamadas person1 e person2.
            person1 = new Pessoa(); // Cria uma instância da classe Pessoa e atribui à variável person1.
            person2 = new Pessoa(); // Cria outra instância da classe Pessoa e atribui à variável person2.

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.name = Console.ReadLine(); // Atribui o nome da primeira pessoa.
            Console.Write("Idade: ");
            person1.age = int.Parse(Console.ReadLine()); // Atribui a idade da primeira pessoa.
            
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.name = Console.ReadLine(); // Atribui o nome da segunda pessoa.
            Console.Write("Idade: ");
            person2.age = int.Parse(Console.ReadLine()); // Atribui a idade da segunda pessoa.

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
