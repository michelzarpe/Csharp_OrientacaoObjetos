using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.domain
{
    class Retangulo:Figura
    {
        private double altura;
        private double largura;

    

        public Retangulo(double altura, double largura, Cor cor, string nome) : base(cor,nome)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double Altura { get => altura; set => altura = value; }
        public double Largura { get => largura; set => largura = value; }

        public override double getArea()
        {
            return (largura * altura) / 2;
        }

        public override string ToString()
        {
            return " Largura: " + largura + " Altura: " + altura+ " AREA: " + getArea()+" Cor: "+this.Cor+" Nome: "+this.Nome;
        }

    }
}
