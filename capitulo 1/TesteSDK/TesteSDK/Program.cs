using System;

using System.Globalization;

namespace Aplication
{
    class Program
    {
         static void Main(string[] args)
        {
            /*Entrada e saida de dados*/
            /*
            string nome = "";
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário Atual");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("R ou U");
            w = char.Parse(Console.ReadLine());
            Console.WriteLine("Variável X ->"+x);
            Console.WriteLine("Variável X com F2 ->" + x.ToString("F2"));
            Console.WriteLine("Variável X com F4 ->" + x.ToString("F4"));
            Console.WriteLine("Variável X com F2 ->" + x.ToString("F2", CultureInfo.InvariantCulture)+" "+ w+"$");
            string[] frase;
            Console.WriteLine("Digite sua frase");
            frase = Console.ReadLine().Split(' ');
            for (int l = 0; l< frase.Length; l++)
            {
                Console.WriteLine(frase[l]);

            }
            */
            /*Exercicio, ler os coeficientes a, b, c, de uma equacao de segundo grau e mostrar o resultado da formula de baskara*/
            /*
            double a, b, c;
            double delta;
            double bhaskaraX1;
            double bhaskaraX2;

            Console.WriteLine("Calculando a Bhaskará");
            Console.WriteLine("Coeficiente a:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Coeficiente b:");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Coeficiente c:");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            delta = Math.Pow(b,2) - 4*a*c;

            if (delta > 0 && a !=0)
            {
                bhaskaraX1 = ((-b) + (Math.Sqrt(delta)))/(2*a); 
                bhaskaraX2 = ((-b) - (Math.Sqrt(delta)))/ (2 * a);
                Console.WriteLine("X1:"+ bhaskaraX1.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("X2:"+ bhaskaraX2.ToString("F2",CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel Calcular");
            }

            */

            int idade = 0;
            int totalIdade =0;
            int quantidadeVezes = 0;
            while (idade>=0)
            {
                Console.WriteLine("Digite uma idade ->:");
                idade = int.Parse(Console.ReadLine());
                if (idade > 0)
                {
                    totalIdade = totalIdade + idade;
                    quantidadeVezes++;
                }
            }
            if (totalIdade > 0)
            {
                double media = (double) (totalIdade / quantidadeVezes);
                Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("IMPOSSIVEL DE CALCULAR");
            }


            Console.ReadLine();







        }
    }
}
