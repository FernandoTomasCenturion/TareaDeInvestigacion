using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDeInvestigacion
{
    public class AvionComercial : Avion
    {
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public AvionComercial()
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
