using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.domain
{
    class FigTriangulo : Figura
    {
        private double a;
        private double b;
        private double c;

        public FigTriangulo(double a, double b, double c, string cor) : base(cor)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double getArea()
        {
            double p = (this.A + this.B + this.C) / 2;
            return Math.Sqrt(p*(p-this.A)*(p -this.B) *(p - this.C));
        }

    }
}
