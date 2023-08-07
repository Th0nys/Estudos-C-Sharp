using System;

namespace ExercicioDeFixacaoEmcapsulamento
{
    class Conta
    {
        public int Id { get; private set; }     // Propriedade para armazenar o ID da conta (somente leitura).
        public string Nome { get; set; }        // Propriedade para armazenar o nome do titular da conta (leitura e escrita).
        public double Saldo { get; private set; } // Propriedade para armazenar o saldo da conta (somente leitura).

        // Construtor para inicializar a conta com ID e nome do titular.
        public Conta(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Construtor para inicializar a conta com ID, nome do titular e saldo.
        public Conta(int id, string nome, double saldo) : this(id, nome)
        {
            Saldo = saldo;
        }

        // Método para realizar um depósito na conta.
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        // Método para realizar um saque na conta (incluindo taxa de $5).
        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        // Sobrescrita do método ToString() para retornar uma representação formatada das informações da conta.
        public override string ToString()
        {
            return $"Conta {Id}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}
