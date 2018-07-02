using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdEPedidos.Domain
{
    class ItemPedido : IComparable
    {
        private int quantidade;
        private double desconto;
        Produto produto;
        Pedido pedido;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        internal Produto Produto { get => produto; set => produto = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }

        public ItemPedido(int quantidade, double desconto, Produto produto, Pedido pedido)
        {
            this.quantidade = quantidade;
            this.desconto = desconto;
            this.produto = produto;
            this.pedido = pedido;
        }


        public ItemPedido(int quantidade, double desconto)
        {
            this.quantidade = quantidade;
            this.desconto = desconto;
        }

        public double subTotal()
        {
            double desconto = (this.produto.Preco * this.desconto / 100);
            return   (this.quantidade * (this.produto.Preco - desconto));
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
