using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoExecessao.Domain.Exeption;
using TratamentoExecessao.Domain;

namespace TratamentoExecessao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb1 = new ContaBancaria(1, "Michel", 150.00);

            try
            {
                cb1.depositar(200.00);
                cb1.sacar(200.00);
         
            }
            catch(OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();

        }
    }
}
