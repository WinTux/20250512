using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoCsharp.POO
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _ci;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string CI
        {
            get { return _ci; }
            set { _ci = value; }
        }
        public Persona()
        {
            this._nombre = "Sin nombre";
            this._apellido = "Sin apellido";
            this._edad = 0;
            this._ci = "Sin ci";
        }
        public Persona(string nombre, string apellido, int edad, string ci)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._ci = ci;
        }
        public void presentarse()
        {
            Console.WriteLine("Hola, soy " + _nombre + " " + _apellido + ", tengo " + _edad + " años y mi CI es " + _ci);
        }
        public void decirEdad()
        {
            Console.WriteLine("Tengo " + _edad + " años");
        }
        public String nombrecompleto()
        {
            return _nombre + " " + _apellido;
        }
    }
}
