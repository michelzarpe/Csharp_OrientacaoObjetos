using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSuprimentos.Domain
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidadeNoEstoque;

        public Produto(string nome, double preco, int quantidadeNoEstoque)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.QuantidadeNoEstoque = quantidadeNoEstoque;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int QuantidadeNoEstoque { get => quantidadeNoEstoque; set => quantidadeNoEstoque = value; }

        public override bool Equals(object obj)
        {
            var produto = obj as Produto;
            return produto != null &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco &&
                   QuantidadeNoEstoque == produto.QuantidadeNoEstoque;
        }

        public override int GetHashCode()
        {
            var hashCode = -1825794190;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            hashCode = hashCode * -1521134295 + QuantidadeNoEstoque.GetHashCode();
            return hashCode;
        }


        public double valorTotalEmEstoque()
        {
            return this.preco * this.quantidadeNoEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            this.quantidadeNoEstoque += quantidade;
        }


        public void realizarSaida(int quantidade)
        {
            this.quantidadeNoEstoque -= quantidade;
        }

        public string ToString()
        {
            return this.nome + ", " +
                "" + this.preco.ToString("F2",CultureInfo.InvariantCulture) + "R$, " +
                "" + this.quantidadeNoEstoque+" unidades, valor total: " +
                ""+ this.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + "R$";
        }

    }
}
