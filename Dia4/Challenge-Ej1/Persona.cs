using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal class Persona
    {
        private string nombre;
        public string Nombre { get => nombre; set=> nombre=value; }
        public Persona() { }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString() { return "Nombre : " + Nombre; }
    }
}
