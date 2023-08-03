using System;

namespace ExercicioClasse4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
             porcentagem = (SalarioBruto * porcentagem) / 100;
             SalarioBruto += porcentagem;
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, ${SalarioLiquido().ToString("F2")}";
        }
    }
}
