using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDeInvestigacion
{
    public abstract class Avion
    { 
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

       public Avion()
        {
        }


        public virtual void Aterriza()
        {
            Console.WriteLine("El avion aterriza");
        }

        public virtual void Despega()
        {
            Console.WriteLine("El avion despega");
        }
    }
}
