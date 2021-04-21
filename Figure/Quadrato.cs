using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Quadrato : FiguraGeometrica
    {
        public Quadrato(double lato) : base(lato) { }

        public override string Descrizione
        {
            get
            {
                return $"Quadrato di lato {valore}";
            }
        }

        public override double Perimetro
        {
            get
            {
                return valore * 4;
            }
        }

        public override double Area
        {
            get
            {
                return valore * valore;
            }
        }
    }
}
