using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDeInvestigacion
{
    public class AvionCarga : Avion
    {
        public int Peso;
        public string TipoDeMercaderia;

        public AvionCarga()
        {
        }

        virtual public new void Aterriza()
        {
            Console.WriteLine("El avion aterriza");
        }

        virtual public new void Despega()
        {
            Console.WriteLine("El avion despega");
        }
    }
}
