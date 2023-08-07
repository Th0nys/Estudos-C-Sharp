using System;

namespace MembrosEstaticosPt1
{
    class Calculadora
    {
        public static double Pi = 3.14; // Declaração de um campo estático para armazenar o valor de Pi.

        // Método estático para calcular a circunferência de uma esfera.
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        // Método estático para calcular o volume de uma esfera.
        public static double Volume(double r)
        {
            return 4.0 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
