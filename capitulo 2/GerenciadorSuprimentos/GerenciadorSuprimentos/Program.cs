using GerenciadorSuprimentos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSuprimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pod1 = new Produto("TV", 900.00, 10);
            Console.WriteLine(pod1.ToString());
            pod1.realizarEntrada(5);
            Console.WriteLine(pod1.ToString());
            pod1.realizarSaida(3);
            Console.WriteLine(pod1.ToString());

            Produto[] produtos = new Produto[2];
            produtos[0] = pod1;
            produtos[0] = new Produto("Som",9550.00);

            Console.WriteLine(produtos[0].Nome);
            Console.ReadLine();
        }
    }
}
