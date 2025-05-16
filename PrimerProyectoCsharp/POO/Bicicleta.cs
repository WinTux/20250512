using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoCsharp.POO
{
    public class Bicicleta
    {
        private string modelo;
        private string marca;
        private int ruedas_size;
        private float peso;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Marca
        {
            get { return "Marca: "+marca; }
            set { 
                if(value.Length < 20)
                    marca = value; 
            }
        }
        public int Ruedas_size
        {
            get { return ruedas_size; }
            set { 
                if(value > 0 && value < 100)
                    ruedas_size = value; 
            }
        }
        public float Peso
        {
            get { return peso; }
            set { 
                if (value > 5 && value < 30)
                    peso = value;
            }
        }
        /* Por abstracción
         
        string color;
        string tipo;
        string material;
        string frenos;
        int cambios;
        */

        // Constructores
        // Constructor por defecto
        public Bicicleta() { 
            modelo = "Sin modelo";
            marca = "Sin marca";
            ruedas_size = 16;
            peso = 0.0f;
        }
        public Bicicleta(string modelo, string marca, int ruedas_size, float peso)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ruedas_size = ruedas_size;
            this.peso = peso;
        }
        public Bicicleta(string modelo) { 
            this.modelo = modelo;
        }
        public Bicicleta(string modelo, string marca) {
            this.modelo = modelo;
            this.marca = marca;
        }
        public Bicicleta(float peso)
        {
            this.peso = peso;
        }
        public Bicicleta(float peso, string marca)
        {
            this.peso = peso;
            this.marca = marca;
        }

        private void calculadorDePeso(float peso1, float peso2, float peso3)
        {
            peso = (peso1 + peso2)/2 + peso3;
        }
    }
}
