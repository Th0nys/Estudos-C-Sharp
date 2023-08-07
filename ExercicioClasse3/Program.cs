using ExercicioClasse3; // Importa o namespace ExercicioClasse3 para utilizar a classe Retangulo.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(); // Cria uma instância da classe Retangulo e atribui à variável 'retangulo'.

            Console.WriteLine("Entre a largura e altura de um retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine()); // Lê a largura do retângulo inserida pelo usuário.
            retangulo.Altura = double.Parse(Console.ReadLine());  // Lê a altura do retângulo inserida pelo usuário.
            Console.WriteLine($"{retangulo}"); // Chama o método 'ToString()' sobrescrito para exibir as informações formatadas do retângulo.
        }
    }
}
