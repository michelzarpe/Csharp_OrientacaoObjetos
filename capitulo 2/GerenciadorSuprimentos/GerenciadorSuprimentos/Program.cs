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
            /*
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

    */
            /*vetorh*/
            int[] vetor = new int[2];

            /*matriz */
            int[,] matriz = new int[3, 3];

            /*listas - acessada pela posicao, mas é redimensionada dinamicamente using System.Colletions.Generic*/
            List<String> lista = new List<String>();
            lista.Add("NANANAN"); int x=lista.Count; string y = lista[0]; lista.Remove("NANANA"); lista.FindIndex(i => i == "NANANA"); /*se for objeto é i.atributo == "NANANAN" */

            /*Conjunto using System.Colletions.Generic, nao adiciona elementos duplicados*/
            /**/
            HashSet<int> ConjuntoA = new HashSet<int>();
            HashSet<int> ConjuntoB = new HashSet<int>();
            ConjuntoA.Add(5); ConjuntoA.Add(8); ConjuntoA.Add(9); ConjuntoA.Add(3);
            ConjuntoB.Add(3); ConjuntoB.Add(4); ConjuntoB.Add(5);

            foreach(int l in ConjuntoA)
            {
                Console.WriteLine(l);
            }

            if (ConjuntoA.Contains(3))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("Não Existe");
            }


            /*remove de a apenas os que tem em b*/
            ConjuntoA.ExceptWith(ConjuntoB);

            /*uniao, adiciona em A o que não tem em A com B*/
            ConjuntoA.UnionWith(ConjuntoB);

            /*deixa apenas os elementos de A, que tem igual em A e B*/
            ConjuntoA.IntersectWith(ConjuntoB);



        }
    }
}
