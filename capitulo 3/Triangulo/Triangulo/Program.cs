using Triangulo.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Figura> lista_figuras = new HashSet<Figura>();


            Console.WriteLine(Tela.getInicio("Michel Zarpelon em "+Mes.Julho));
            lista_figuras.Add(new FigTriangulo(4.00,4.50,5.00,Cor.Amarelo,"Triangulo"));
            lista_figuras.Add(new Retangulo(12.00,15.00,Cor.Verde,"Retangulo"));
            lista_figuras.Add(new FigTriangulo(3.00, 4.50, 5.00, Cor.Preto, "Triangulo"));
            
            foreach(Figura f in lista_figuras)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();


        }
    }
}
