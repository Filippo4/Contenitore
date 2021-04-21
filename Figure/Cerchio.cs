using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Cerchio : FiguraGeometrica
    {
        public Cerchio(double raggio) : base(raggio) { }

        public override string Descrizione
        {
            get
            {
                return $"Cerchio di raggio {valore}";
            }
        }

        public override double Perimetro
        {
            get
            {
                return 2 * Math.PI * valore;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * valore * valore;
            }
        }
    }
}
