using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public abstract class PoliticaSelezione
    {
        protected double soglia;

        public PoliticaSelezione(double soglia)
        {
            this.soglia = soglia;
        }

        /// <summary>
        /// Seleziona la figura in base alla politica
        /// </summary>
        /// <param name="f">figura</param>
        /// <returns>True se la figura è selezionata, False altrimenti</returns>
        public abstract bool Seleziona(FiguraGeometrica f);
    }
}
