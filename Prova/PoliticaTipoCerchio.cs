using Figure;
using Politiche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class PoliticaTipoCerchio : PoliticaSelezione
    {
        public PoliticaTipoCerchio() : base(0) { }

        public override bool Seleziona(FiguraGeometrica f)
        {
            return f is Cerchio;
        }
    }
}
