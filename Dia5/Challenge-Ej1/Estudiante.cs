using System;

namespace Challenge_Ej1
{
    internal class Estudiante: Persona
    {
        public int edad { get; set; }
        public int Edad { get { return edad; } set { edad = value; } }
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public void VerEdad() { Console.WriteLine("Mi edad es: {0} años"/*, Persona.*/); }
    }
}
