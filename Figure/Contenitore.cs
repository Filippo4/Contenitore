using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Contenitore
    {
        private List<FiguraGeometrica> figure = new List<FiguraGeometrica>();

        public Contenitore() { }

        public void AggiungiFigura(FiguraGeometrica f)
        {
            figure.Add(f);
        }

        public void ElencaFigure()
        {
            foreach (FiguraGeometrica f in figure)
            {
                Console.WriteLine(f.Descrizione);
            }
        }

        public void Svuota()
        {
            figure.Clear();
        }

        public List<FiguraGeometrica> Figure
        {
            get
            {
                return figure;
            }
        }
    }
}
