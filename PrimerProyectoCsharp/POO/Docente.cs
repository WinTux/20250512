using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoCsharp.POO
{
    public class Docente : Ciudadano
    {
        public Docente() { }

        public void votar()
        {
            Console.WriteLine("Soy docente y puedo votar");
        }

        public void migrar()
        {
            Console.WriteLine("Soy docente y puedo migrar");
        }
        public void respirar()
        {
            Console.WriteLine("Soy docente y puedo respirar");
        }
    }
}
