using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class FiguraGeometrica
    {
        protected double valore;

        public FiguraGeometrica(double valore)
        {
            this.valore = valore;
        }

        public abstract string Descrizione { get; }

        public abstract double Perimetro { get; }

        public abstract double Area { get; }
    }
}
