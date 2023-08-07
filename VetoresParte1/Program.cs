using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Lê o número inteiro N, que representa a quantidade de pessoas.

            double[] vect = new double[n]; // Cria um vetor de tamanho N para armazenar as alturas.
            double sum = 0; // Variável para armazenar a soma das alturas.

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine()); // Lê a altura da pessoa e armazena no vetor.
                sum += vect[i]; // Adiciona a altura lida à soma total.
            }

            double AltMedia = sum / n; // Calcula a média das alturas.

            Console.WriteLine($"AVERAGE HEIGHT: {AltMedia.ToString("F2")}"); // Exibe a média das alturas formatada com duas casas decimais.
        }
    }
}
