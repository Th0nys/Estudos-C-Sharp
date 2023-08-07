using MembrosEstaticosPt1; // Importa o namespace MembrosEstaticosPt1 para usar a classe Calculadora.
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine()); // Lê o valor do raio da esfera inserido pelo usuário.

            double circ = Calculadora.Circunferencia(raio); // Calcula a circunferência utilizando o método estático Circunferencia da classe Calculadora.
            double volume = Calculadora.Volume(raio); // Calcula o volume utilizando o método estático Volume da classe Calculadora.

            Console.WriteLine($"Circunferencia: {circ.ToString("F2")}"); // Exibe o valor da circunferência formatado com duas casas decimais.
            Console.WriteLine($"Volume: {volume.ToString("F2")}"); // Exibe o valor do volume formatado com duas casas decimais.
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2")}"); // Exibe o valor de Pi formatado com duas casas decimais.
        }
    }
}
