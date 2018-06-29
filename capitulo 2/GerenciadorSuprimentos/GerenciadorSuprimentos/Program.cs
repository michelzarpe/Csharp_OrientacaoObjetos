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

            Console.ReadLine();
        }
    }
}
