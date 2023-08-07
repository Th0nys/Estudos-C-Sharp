using ExercicioVetores;
using System;

/* A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos
 * identificados pelos numeros 0 a 9.
 * 
 * Fazer um programa que inicie com todos os dez quartos vazios, e depois leia
 * uma quantidade N repredentando o numero de estudantes que vao alugar quartos
 * (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada
 * registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos
 * ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa
 * deve imprimir um relatorio de todas ocupacoes do pensionato, por ordem de quarto*/

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Pensionato[] vect = new Pensionato[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[i] = new Pensionato { Name = name, Email = email, Room = room };
            }

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

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{vect[i].Room}: {vect[i].Name}, {vect[i].Email}");
            }
        }
    }
}