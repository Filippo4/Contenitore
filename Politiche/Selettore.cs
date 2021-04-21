using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public class Selettore : Contenitore
    {

        private PoliticaSelezione politica;

        public void ImpostaPolitica(PoliticaSelezione p)
        {
            politica = p;
        }

        public void ScansionaContenitore(Contenitore c)
        {
            if (politica != null)
                foreach (FiguraGeometrica f in c.Figure)
                {
                    if (politica.Seleziona(f))
                        AggiungiFigura(f);
                }
        }
    }
}
