using otrito;
using PrimerProyectoCsharp.POO;
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
            otrito.anidado.otro2.EjemploNamespace ejemplo = new otrito.anidado.otro2.EjemploNamespace();
            tiposDeDatos();
            int res = multiplicar(5, 10);
            Console.WriteLine("El resultado de la multiplicacion es: " + res);
            #region Programación Orientada a Objetos
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.WriteLine("**** PROGRAMACIÓN ORIENTADA A OBJETOS ");
            Bicicleta bici = new Bicicleta();
            Console.WriteLine("Habemus bicicletum");
            #region Encapsulamiento
            Console.WriteLine("El modelo de la bicicleta es: " + bici.Modelo);
            Bicicleta bici2 = new Bicicleta("Urbano", "Bianchi", 26, 12.5f);
            Console.WriteLine("El modelo de la bicicleta es: " + bici2.Modelo);
            Bicicleta bici3 = new Bicicleta("X11");
            bici2.Ruedas_size = 8000;
            bici2.Peso = -23.0008f;
            //bici2.calculadorDePeso(10.5f, 12.5f, -15.5f);
            Console.WriteLine("El modelo de la bicicleta es: " + bici2.Modelo + ", su tamaño de rueda es: "+bici2.Ruedas_size + "[in] y el peso es "+ bici2.Peso+"[kg]");
            #endregion

            #region Herencia
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** HERENCIA ");
            Persona persona = new Persona();
            persona.Nombre = "Pepe";
            persona.Apellido = "Perales";
            Console.WriteLine("El nombre de la persona es: " + persona.Nombre + " " + persona.Apellido);
            persona.presentarse();
            persona.decirEdad();
            persona.nombrecompleto();
            Estudiante est01 = new Estudiante(123456,"Ing. Sistemas");
            Console.WriteLine("El nombre del estudiante es: " + est01.Nombre + " " + est01.Apellido);
            Console.WriteLine("La matrícula del estudiante es: " + est01.Matricula + " y su carrera es "+est01.Carrera);
            Estudiante est02 = new Estudiante("Ana","Roca",23,54321,5000091,"Admin. de Empresas");
            est02.presentarse(); // :u   O.O
            est02.presentarseComoEstudiante();
            #endregion

            #region Polimorfismo 
            Estudiante est03 = new Estudiante(123456, "Ing. Agropecuaria");
            est03.votar();
            Ciudadano[] ciudadanos = new Ciudadano[2];// [][]
            ciudadanos[0] = est03;
            ciudadanos[1] = new Docente();

            //Ejemplo errado
            //Ciudadano ciu = new Ciudadano();

            ciudadanos[0].votar();
            ciudadanos[1].votar();
            #endregion

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Estructuras de datos

            // Estructuras estáticas
            //Arreglos
            int[] arreglo = new int[5]; // [][][][][] -> 10, 0, -3, 5356000, 0; 0,0,0,0,0
            int[] arr_aux = new int[6];
            arr_aux[0] = arreglo[0];

            arr_aux[1] = arreglo[1];
            arr_aux[2] = arreglo[2];
            arr_aux[3] = arreglo[3];
            arr_aux[4] = arreglo[4];
            arr_aux[5] = 10;
            arreglo = arr_aux;
            Console.WriteLine("El tamaño del arreglo es: " + arreglo.Length);
            Console.WriteLine("El primer elementodel arreglo es: " + arreglo[0]);
            /*
            
            [             ] 0   4
            [             ] 1   3
            [             ] 2   2
            [             ] 3   1
            [             ] 4   0
             */
            int[,] arreglo2 = new int[5,3]; // fila, columna
            /*
            
            [10][20][30]
            [40][][]
            [][][]
            [][][]
            [][][]
             
            [10][40][][][]
            [20][][][][]
            [30][][][][]
             
             */
            arreglo2[0,0] = 10;
            arreglo2[0, 1] = 20;
            arreglo2[0, 2] = 30;
            arreglo2[1, 0] = 40;
            //Ejemplo errado
            //arreglo2[2, 4] = 50;

            int[,,] arreglo3D = new int[5, 3, 2]; // fila, columna, profundidad
            /*
            0      1

                    0 1 2
            [][][] [][][] 0 
            [][][] [][][] 1
            [][][] [][][] 2
            [][][] [][][] 3
            [][][] [][][] 4
             */

            int[,,,,] arreglo5D = new int[5, 3, 2, 4, 6]; // fila, columna, profundidad, algo1, algo2
            arreglo5D[2, 0, 1, 3, 3] = 10;
            // Estructuras dinámicas
            // Listas
            List<int> listita = new List<int>();
            listita.Add(10);
            listita.Add(20);
            listita.Add(30);
            // Iteración: for, while, foreach, do-while
            for (int i = 0; i < listita.Count; i++)
            {
                Console.WriteLine("El valor de la lista es: " + listita[i]);
            }
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(est01);
            estudiantes.Add(est02);
            estudiantes.Add(est03);
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine("El valor de la lista de estudiantes es: " + estudiantes[i].ToString());
            }

            Console.WriteLine("Ese es el estudiante est01:");
            Console.WriteLine(est01.Apellido);
            Console.WriteLine("Ese es el estudiante est02:");
            Console.WriteLine(est02.Nombre);
            // Eliminar elementos
            listita.Remove(20);
            // ¿funcionará con estudiantes? ¿cómo?

            // Cola y Pilas
            #endregion

        }

        private static void tiposDeDatos()
        {
            //Numericos
            int entero = 15;
            short a =15;
            byte b = 15;
            long numero_grande = 15;
            float decimalFlotante = 10.5f;
            double decimalDoble = 10.5;
            decimal decimalDecimal = 10.5m;
            
            entero = int.MaxValue; // 2147483647
            Console.WriteLine("El valor maximo de un entero es: " + entero);
            entero++;
            Console.WriteLine("El valor maximo de un entero es: " + entero);
            //Caracteres
            char caracter = 'a';
            caracter = '@';
            String texto = "Pedro \"Pe\npe\" Pe\trales";
            Console.WriteLine("El texto es: " + texto);
        }
        public static int multiplicar(int x, int y) {
            /*
            int resultado; // Declaro
            resultado = x * y; // Inicializo
            return resultado; // Retorno
            */
            return x * y; // Retorno
        }
    }
}
