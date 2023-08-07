using ExercicioVetores; // Importa o namespace ExercicioVetores para utilizar a classe Pensionato.
using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine()); // Lê o número de quartos que serão alugados.

            Pensionato[] vect = new Pensionato[10]; // Cria um vetor de objetos Pensionato com 10 posições.

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine(); // Lê o nome do estudante.
                Console.Write("Email: ");
                string email = Console.ReadLine(); // Lê o email do estudante.
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine()); // Lê o número do quarto escolhido.

                vect[i] = new Pensionato { Name = name, Email = email, Room = room }; // Cria um objeto Pensionato com as informações lidas e armazena no vetor.
            }

            // Ordena os quartos ocupados em ordem crescente.
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vect[j].Room > vect[j + 1].Room)
                    {
                        Pensionato temp = vect[j];
                        vect[j] = vect[j + 1];
                        vect[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Busy rooms in ascending order:");

            // Exibe o relatório dos quartos ocupados em ordem ascendente.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{vect[i].Room}: {vect[i].Name}, {vect[i].Email}");
            }
        }
    }
}
