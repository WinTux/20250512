namespace PrimerProyectoCsharp
{
    internal class Prog
    {
        public void Metodo1(string[] cosa) { 
        
        }
        public static int OtroMetodo() {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            return b; // expresión
        }
    }

    public class Programita {
        public static int OtroMetodo()
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            return b; // expresión
        }
    }
}

namespace temporal { 
    public class ClaseTemporal{
        public static int OtroMetodo()
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            return b; // expresión
        }
    }
}
namespace otrito {
    public class Clasesita {
        public static void Metodo() { }
    }
    namespace anidado {

        namespace otro2 {
            public class EjemploNamespace { 
            
            }
        }
    }
}
