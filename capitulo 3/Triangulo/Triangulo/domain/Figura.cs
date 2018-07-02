using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.domain
{
    abstract class Figura
    {
        private Cor cor;
        private string nome;
  

        public Figura(Cor cor, string nome)
        {
            this.cor = cor;
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        internal Cor Cor { get => cor; set => cor = value; }

        public abstract double getArea();

    }
}
