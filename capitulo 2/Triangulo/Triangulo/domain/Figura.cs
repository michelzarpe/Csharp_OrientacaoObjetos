using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.domain
{
    class Figura
    {
        private string cor;
        private string material;

        public Figura(string cor)
        {
            this.cor = cor;
        }

        public string Material { get => material; set => material = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
