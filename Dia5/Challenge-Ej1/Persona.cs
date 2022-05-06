using System;

namespace Challenge_Ej1
{
    internal class Persona
    {
        private int edad;
        private string nombre;
        public int Edad { get { return edad; } set { edad = value; } }
        public string Nombre { get => nombre; set => nombre = value; }
        public Persona() { }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString() { return "Nombre : " + Nombre; }
        public void Saludar()
        {
            Console.WriteLine("Hola");
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
