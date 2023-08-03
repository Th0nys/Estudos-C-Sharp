using System;

/*Fazer um programa para ler um numero inteiro N e a altura de N pessoas.
Amazene as N alturas em um vetor. Em seguida, mostrar a altura media dessas pessoas*/

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
                sum += vect[i];
            }

            double AltMedia = sum / n;

            Console.WriteLine($"AVERAGE HEIGHT: {AltMedia.ToString("F2")}");
        }
    }
}