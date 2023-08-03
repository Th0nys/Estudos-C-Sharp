using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse5
{
    class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;

        public double SomaNotas()
        {
            return NotaA + NotaB + NotaC;
        }

        public override string ToString()
        {
            if (SomaNotas() >= 60)
            {
                return $"Nota Final = {SomaNotas().ToString("F2")}\nAPROVADO";
            }
            else
            {
                double faltaram = 60.0 - SomaNotas();
                return $"Nota Final = {SomaNotas().ToString("F2")}\nREPROVADO\nFaltaram {faltaram.ToString("F2")} PONTOS";
            }
        }
    }
}
