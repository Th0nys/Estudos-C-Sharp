using System;

namespace ExercicioClasse5
{
    class Aluno
    {
        public string Nome;        // Campo público para armazenar o nome do aluno.
        public double NotaA, NotaB, NotaC; // Campos públicos para armazenar as notas do aluno.

        public double SomaNotas()
        {
            return NotaA + NotaB + NotaC; // Calcula e retorna a soma das notas do aluno.
        }

        public override string ToString()
        {
            if (SomaNotas() >= 60)
            {
                return $"Nota Final = {SomaNotas().ToString("F2")}\nAPROVADO"; // Retorna uma mensagem de aprovação se a nota final for maior ou igual a 60.
            }
            else
            {
                double faltaram = 60.0 - SomaNotas();
                return $"Nota Final = {SomaNotas().ToString("F2")}\nREPROVADO\nFaltaram {faltaram.ToString("F2")} PONTOS"; // Retorna uma mensagem de reprovação se a nota final for menor que 60, mostrando quantos pontos faltaram.
            }
        }
    }
}
