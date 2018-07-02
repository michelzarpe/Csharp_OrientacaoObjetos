using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorProdEPedidos.Domain;

namespace GerenciadorProdEPedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ItemPedido> list_itemPedido = new List<ItemPedido>();


            Produto p1 = new Produto(1001,"Cadeira Simples",500.00);
            Produto p2 = new Produto(1002, "Cadeira Acolchoada", 900.00);
            Produto p3 = new Produto(1003, "Sofa três lugares", 2000.00);
            Produto p4 = new Produto(1004, "Mesa Retangular", 1500.00);
            Produto p5 = new Produto(1005, "Mesa Retangular", 2000.00);

            Pedido pedido = new Pedido(1001, new DateTime(2018, 07, 01));
           

            
            ItemPedido ip1 = new ItemPedido(1,5.0);
           
            ItemPedido ip2 = new ItemPedido(4, 10.0);

            ip1.Produto = p1;
            ip2.Produto = p5;

            ip1.Pedido = pedido;
            ip2.Pedido = pedido;

            list_itemPedido.Add(ip1);
            list_itemPedido.Add(ip2);

       
            pedido.Itens = list_itemPedido;


            Console.WriteLine(pedido);
            Console.ReadLine();


         



        }
    }
}
