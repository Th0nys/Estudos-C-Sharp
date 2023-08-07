using System;

namespace ExercicioClasse4
{
    class Funcionario
    {
        public string Nome;          // Campo público para armazenar o nome do funcionário.
        public double SalarioBruto;  // Campo público para armazenar o salário bruto do funcionário.
        public double Imposto;       // Campo público para armazenar o valor do imposto sobre o salário.

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto; // Calcula e retorna o salário líquido do funcionário.
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = (SalarioBruto * porcentagem) / 100; // Calcula o aumento em dólares.
            SalarioBruto += porcentagem; // Aumenta o salário bruto do funcionário.
        }

        public override string ToString()
        {
            // Retorna uma representação em string das informações do funcionário, incluindo nome e salário líquido.
            return $"Funcionario: {Nome}, ${SalarioLiquido().ToString("F2")}";
        }
    }
}
