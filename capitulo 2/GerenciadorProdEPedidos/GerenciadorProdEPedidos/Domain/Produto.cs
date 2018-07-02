using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdEPedidos.Domain
{
    class Produto : IComparable
    {
        private uint codigo;
        private string descricao;
        private double preco;

        public Produto(uint codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public uint Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }

        public int CompareTo(object obj)
        {
            Produto prodAux = (Produto) obj;

            int resultad = this.descricao.CompareTo(prodAux.Descricao);
            if(resultad != 0)
            {
                return resultad;
            }
            else
            {
                return -this.preco.CompareTo(prodAux.Preco);
            }
            
        }

        public override string ToString()
        {
            return "Prod: " + this.codigo + ", " + this.descricao + ", " + this.preco + " R$"; 
        }


    }
}
