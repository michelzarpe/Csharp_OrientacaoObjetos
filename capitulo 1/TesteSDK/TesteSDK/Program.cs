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
              */


            /*
            Console.WriteLine("Interações do loop->");
            int n = int.Parse(Console.ReadLine());
            for (int linha=0;linha<n;linha++)
            {
                Console.WriteLine("Valores Pares");
                String [] vetor = Console.ReadLine().Split(' ');
                if (double.Parse(vetor[1]) > 0)
                {
                    Console.WriteLine("-> "+ (double.Parse(vetor[0])/(double.Parse(vetor[1]))).ToString("F4",CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Não existe");
                }

            }


         



            int volumeInicial = 500;
            int vazaoBomba = 10;
            int tempo = 60;
            if ((tempo*vazaoBomba)<volumeInicial)
            {
                Console.WriteLine(volumeInicial - (tempo*vazaoBomba));
            }
            else
            {
                Console.WriteLine("não é Possivel");
            }

            

            Console.WriteLine("foto e Porta retrato -> Largura Altura");
            String[] foto = Console.ReadLine().Split(' ');
            String[] portaRetrato = Console.ReadLine().Split(' ');

            int larguraFoto = int.Parse(foto[0]);
            int alturaFoto = int.Parse(foto[1]);

            int larguraPorta = int.Parse(portaRetrato[0]);
            int alturaPorta = int.Parse(portaRetrato[1]);




            //paisagem
            if (larguraFoto <= larguraPorta && alturaFoto <= alturaPorta)
            {
                Console.WriteLine("Sim 1");
            }
            else
            {
                if (larguraFoto <= alturaPorta && alturaFoto <= larguraPorta)
                {
                    Console.WriteLine("Sim 2");
                }
                else
                {
                    Console.WriteLine("Não");
                }

            }

       


            Console.WriteLine("digite os 3 Arremessos: ");
            String[] vetor = Console.ReadLine().Split(' ');
            double[] arremessos = new double[vetor.Length];
            double aux = 0;

            for (int coluna = 0; coluna < vetor.Length; coluna++)
            {
                 arremessos[coluna] = double.Parse(vetor[coluna],CultureInfo.InvariantCulture);
                 if (arremessos[coluna] > aux)
                     aux = arremessos[coluna];

            }
            Console.WriteLine(aux);

      

            Console.WriteLine("Dois Numeros Inteiros:");
            String[] vetor = Console.ReadLine().Split(' ');
            int[] numeroDigitados = new int[vetor.Length];
            int menor=99999999, maior=0;
            int soma = 0;
            for (int indice = 0; indice < vetor.Length; indice++)
            {
                numeroDigitados[indice] = int.Parse(vetor[indice]);
                if (numeroDigitados[indice] > maior)
                    maior = numeroDigitados[indice];

                if (numeroDigitados[indice] < menor)
                    menor = numeroDigitados[indice];

            }
            for (int indice = menor; indice < maior; indice++)
            {
                if (indice % 2 != 0)
                    soma = soma + indice;  
            }
            Console.WriteLine("Soma:"+soma);
            
             


            double duracaoBateria = 10.0;
            int partidas = 3;
            double[] horasDeJogoPorPartida = new double[] {5.0, 5.0, 5.0};
            double totalHorasDesejadaAJogar=0;
            double minutosSobrandoPorPartida = 0;

            for (int indice = 0; indice < horasDeJogoPorPartida.Length; indice++)
            {
                totalHorasDesejadaAJogar = totalHorasDesejadaAJogar + horasDeJogoPorPartida[indice];
            }

            minutosSobrandoPorPartida = duracaoBateria;

            for (int indice = 0; indice < horasDeJogoPorPartida.Length; indice++)
            {
                minutosSobrandoPorPartida = minutosSobrandoPorPartida - horasDeJogoPorPartida[indice];
                if (minutosSobrandoPorPartida<0)
                {
                    Console.WriteLine("Recarregar");
                }
                else
                {
                    Console.WriteLine(minutosSobrandoPorPartida.ToString("F1"));
                }
            }

            */
            int volume = 0;
            int verificacao = 1;
            int volumeEquipamento = 0;
            int interacao = 0;
            Console.WriteLine("Volume do Equipamento: ");
            volume = int.Parse(Console.ReadLine());
            while (volume != 0)
            {

                if (volume >= 100)
                {
                    volumeEquipamento = (volume >= 100) ? 100 : 0;

                    if (interacao != 0)
                    { Console.WriteLine(volumeEquipamento); }


                }
                else
                {
                    volumeEquipamento = volumeEquipamento + volume;
                    if (volumeEquipamento >= 100 || volumeEquipamento <= 0)
                    {
                        volumeEquipamento = (volumeEquipamento >= 100) ? 100 : 0;

                        if (interacao != 0)
                        { Console.WriteLine(volumeEquipamento); }
                    }
                    else
                    {
                        if (interacao != 0)
                        { Console.WriteLine(volumeEquipamento); }
                    }
                }
                interacao++;
                Console.WriteLine("Volume do Equipamento: ");
                volume = int.Parse(Console.ReadLine());
            }





            Console.ReadLine();
        }
    }
}
