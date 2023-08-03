using System;
using System.Reflection.Metadata.Ecma335;

namespace ExercicioDeFixacaoEmcapsulamento
{
    class Conta
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Conta(int id, string nome, double saldo) : this(id, nome){
            Saldo = saldo;
        }

        public void Deposito(double quantia){
            Saldo += quantia;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return $"conta {Id}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}
