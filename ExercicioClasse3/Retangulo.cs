using System;

namespace ExercicioClasse3
{
    class Retangulo
    {
        public double Largura; // Campo público para armazenar a largura do retângulo.
        public double Altura;  // Campo público para armazenar a altura do retângulo.

        public double Area()
        {
            return Largura * Altura; // Calcula e retorna a área do retângulo.
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura); // Calcula e retorna o perímetro do retângulo.
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2)); // Calcula e retorna a diagonal do retângulo.
        }

        public override string ToString()
        {
            // Retorna uma representação em string das informações do retângulo, incluindo área, perímetro e diagonal.
            return $"AREA = {Area().ToString("F2")}\nPERIMETRO: {Perimetro().ToString("F2")}\nDIAGONAL: {Diagonal().ToString("F2")}";
        }
    }
}
