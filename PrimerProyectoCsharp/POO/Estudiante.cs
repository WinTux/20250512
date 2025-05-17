using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoCsharp.POO
{
    public class Estudiante : Persona
    {
        public int Matricula { get; set; }
        public string Carrera { get; set; }
        public Estudiante(int matricula, string carrera)
        {
            this.Matricula = matricula;
            this.Carrera = carrera;
        }
        public Estudiante(string nombre, string apellido, int edad, int matricula, int ci, string carrera) : base(nombre, apellido, edad, ci.ToString())
        {
            this.Matricula = matricula;
            this.Carrera = carrera;
        }
        public void presentarseComoEstudiante() { 
            Console.WriteLine("Hola, soy el/la estudiante " + Nombre + " " + Apellido + ", tengo " + Edad + " años y mi CI es " + CI + ". Estoy en la carrera " + Carrera + " con matrícula "+Matricula);
        }
        
        public void presentarse() {
            Console.WriteLine("Hola, soy el/la estudiante " + Nombre + " " + Apellido + ", tengo " + Edad + " años y mi CI es " + CI + ". Estoy en la carrera " + Carrera + " con matrícula " + Matricula);
        }
    }
}
