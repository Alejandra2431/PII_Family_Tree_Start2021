using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Persona
    {
        public string nombre{get;set;}
        public int edad{get; set;}
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}