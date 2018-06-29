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
            FigTriangulo x = new FigTriangulo(3.00,4.00,5.00,"Amarelo");
            FigTriangulo y = new FigTriangulo(7.50, 4.50, 4.02, "Azul");

            

            Console.WriteLine(x.Cor+" area -> "+x.getArea());
            Console.WriteLine(y.Cor+" area -> "+y.getArea());
            Console.ReadLine();


        }
    }
}
