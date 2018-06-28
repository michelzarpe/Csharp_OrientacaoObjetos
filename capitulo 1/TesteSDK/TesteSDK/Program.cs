using System;
using System.Globalization;

namespace Aplication
{
    class Program
    {
         static void Main(string[] args)
        {
            string nome = "";
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';



            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Variável X ->"+x);
            Console.WriteLine("Variável X com F2 ->" + x.ToString("F2"));
            Console.WriteLine("Variável X com F4 ->" + x.ToString("F4"));
            Console.WriteLine("Variável X com F2 ->" + x.ToString("F2"),CultureInfo.InvariantCulture);
         



            Console.ReadLine();







        }
    }
}
