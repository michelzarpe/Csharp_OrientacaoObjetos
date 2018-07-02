using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoExecessao.Domain.Exeption;

namespace TratamentoExecessao.Domain
{
    class ContaBancaria
    {
        private int numeroConta;
        private string nomeTitular;
        private double limiteSaque;
        private double saldo;

        public ContaBancaria(int numeroConta, string nomeTitular, double limiteSaque)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.limiteSaque = limiteSaque;
            this.saldo = 0;
        }

        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public string NomeTitular { get => nomeTitular; set => nomeTitular = value; }
        public double LimiteSaque { get => limiteSaque; set => limiteSaque = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public double depositar(double valor)
        {
            return this.saldo = this.saldo + valor;
        }


        public void sacar(double valor)
        {
            if (valor <= this.saldo && valor <= this.limiteSaque)
            {
                this.saldo = this.saldo - valor;
            }

            if (valor > this.saldo)
                throw new OperacaoException("Sem saldo");

            if (valor > this.limiteSaque)
                throw new OperacaoException("Limite Exedido");


        }

    }
}
