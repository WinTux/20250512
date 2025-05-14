using otrito;
using temporal;
namespace PrimerProyectoCsharp
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola x todos!!!!!");
            int x;
            int b;
            int c;
            b = 5;
            c = 10;
            x = 3;
            x = x + 1; // x = x;  x = f -> f = x
            x = x + 1;
            x = x + 1;
            x++;
            int n = Prog.OtroMetodo();
            n = Programita.OtroMetodo();
            n = ClaseTemporal.OtroMetodo();
            Clasesita.Metodo();
            Console.WriteLine("El valor de n es: " + n);
            if (x == 5)
            {
                Console.WriteLine("El valor de x es 5");
            }
            else
            {
                Console.WriteLine("El valor de x no es 5");
            }
            if (x > 5)
            {
                n = 10;
                x = 0;
                Console.WriteLine("El valor de x es: " + x);
            }
            else
                n = 20;
            c = x >= 100 ? b : c / 10;
            /*
             a>b && a>c
            a>6 || c>8
              ~ ¬ 
            !(a>b)
             a + b
            a - b
             a * b
             a / b
            b++
            ++b
            b--
            --b
             */
        }
    }
}
