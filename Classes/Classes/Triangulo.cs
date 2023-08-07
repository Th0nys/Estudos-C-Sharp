using System;

namespace Classes
{
    internal class Triangulo
    {
        public double A, B, C; // Três lados do triângulo.

        public double Area() // Método para calcular a área do triângulo.
        {
            double p = (A + B + C) / 2.0; // Semi perímetro do triângulo.
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Fórmula de Heron para calcular a área.
        }
    }
}
