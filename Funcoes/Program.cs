using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); // Lê o primeiro número inteiro inserido pelo usuário.
            int n2 = int.Parse(Console.ReadLine()); // Lê o segundo número inteiro inserido pelo usuário.
            int n3 = int.Parse(Console.ReadLine()); // Lê o terceiro número inteiro inserido pelo usuário.

            Console.WriteLine(Maior(n1, n2, n3)); // Chama a função Maior e exibe o resultado.
        }

        static int Maior(int x, int y, int z)
        {
            int m;

            if (x > y && x > z) // Verifica se x é o maior número.
            {
                m = x;
            }
            else if (y > z && y > x) // Verifica se y é o maior número.
            {
                m = y;
            }
            else
            {
                m = z; // Se as duas condições anteriores forem falsas, z é o maior número.
            }
            return m; // Retorna o maior número encontrado.
        }
    }
}
