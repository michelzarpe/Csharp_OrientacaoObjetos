using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdEPedidos.Domain
{
    class Pedido : IComparable
    {
        private uint codigo;
        private DateTime dataEmissao;
        private List<ItemPedido> itens = new List<ItemPedido>();

        public Pedido(uint codigo, DateTime dataEmissao)
        {
            this.codigo = codigo;
            this.dataEmissao = dataEmissao;
        }

        public uint Codigo { get => codigo; set => codigo = value; }
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        internal List<ItemPedido> Itens { get => itens; set => itens = value; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public double valorTotal()
        {
            double total = 0;
            foreach (ItemPedido item in itens)
            {
                total = total + item.subTotal();
            }

            return total;
        }

        public override string ToString()
        {
            int contador = 0;
            String s = "";
            foreach (ItemPedido item in itens)
            {
                s = s + "\n Item Pedido, "+ (++contador) +" quantidade: " + item.Quantidade + " desconto: " + item.Desconto + "% Subtotal: " + item.subTotal() + " R$, Produto: "+item.Produto;
            }
            return " Pedido: " + this.codigo + "\n " + this.dataEmissao.ToString() + "\n Itens: " + s + "\n TOTAl Pedido " + this.valorTotal();
        }


    }
}
