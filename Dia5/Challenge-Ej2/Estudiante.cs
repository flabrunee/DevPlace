using System;

namespace Challenge_Ej2
{
    internal class Estudiante : Persona
    {
       /* public int edad { get; set; }
        public int id { get; set; }*/
        public int Edad { get { return edad; } set { edad = value; } }
        public void Estudiante(int edad, string nombre)
        {
            this.edad = edad;
            base.Nombre = nombre;
        }
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public void VerEdad() { Console.WriteLine("Mi edad es: {0} años"/*, Persona.*/); }
    }
}
