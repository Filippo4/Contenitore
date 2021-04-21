using Figure;
using Politiche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenitore c = new Contenitore();
            c.AggiungiFigura(new Cerchio(2));
            c.AggiungiFigura(new Quadrato(3));
            c.AggiungiFigura(new Quadrato(4));
            Console.WriteLine("Contenitore:");
            c.ElencaFigure();

            Selettore s = new Selettore();
            s.ScansionaContenitore(c);
            Console.WriteLine("Selettore senza politiche:");
            s.ElencaFigure();
            s.ImpostaPolitica(new PerimetroMinimo(14));
            s.ScansionaContenitore(c);
            Console.WriteLine("Selettore con politica perimetro:");
            s.ElencaFigure();

            s.Svuota();
            s.ImpostaPolitica(new AreaMassima(15));
            s.ScansionaContenitore(c);
            Console.WriteLine("Selettore con politica area:");
            s.ElencaFigure();

            s.Svuota();
            s.ImpostaPolitica(new PoliticaTipoCerchio());
            s.ScansionaContenitore(c);
            Console.WriteLine("Selettore con politica cerchio:");
            s.ElencaFigure();

            s.Svuota();
            s.ElencaFigure();

            Console.ReadLine();
        }
    }
}
