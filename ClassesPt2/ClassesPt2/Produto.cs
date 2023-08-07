using System;

namespace ClassesPt2
{
    class Produto
    {
        private string _nome; // Campo privado para armazenar o nome do produto.
        public double Preco { get; private set; } // Propriedade pública para obter o preço do produto (com setter privado).
        public int Quantidade { get; private set; } // Propriedade pública para obter a quantidade do produto em estoque (com setter privado).

        public Produto()
        {
            // Construtor vazio.
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade; // Calcula e retorna o valor total do estoque.
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; // Adiciona a quantidade especificada ao estoque.
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade; // Remove a quantidade especificada do estoque.
        }

        public override string ToString()
        {
            // Retorna uma representação em string do objeto Produto, incluindo nome, preço, quantidade em estoque e valor total do estoque.
            return $"Nome: {_nome}, Preco: {Preco.ToString("F2")}, Quantidade em estoque: {Quantidade} unidades, Total: {ValorTotalEmEstoque().ToString("F2")} ";
        }
    }
}
