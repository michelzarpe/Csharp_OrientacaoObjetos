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
            Figura x = new FigTriangulo(3.00, 4.00, 5.00, "Amarelo","Triangulo");
            Figura y = new FigTriangulo(7.50, 4.50, 4.02, "Azul","Triangulo");



            Console.WriteLine(x.Cor + " area -> " + x.getArea());
            Console.WriteLine(y.Cor + " area -> " + y.getArea());

            HashSet<Figura> lista_figuras = new HashSet<Figura>();

            lista_figuras.Add(new FigTriangulo(4.00,4.50,5.00,"Azul","Triangulo"));
            lista_figuras.Add(new Retangulo(12.00,15.00,"Amarelo","Retangulo"));
            lista_figuras.Add(new FigTriangulo(3.00, 4.50, 5.00, "Verde", "Triangulo"));
            
            foreach(Figura f in lista_figuras)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();


        }
    }
}
