using ExercicioClasse3;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura de um retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"{retangulo}");
        }
    }
}
