using System;

namespace Challenge_Ej3
{
    internal interface Forma
    {
        protected Ubicacion ubicacion { get; set; }
        public double Area();
        public double Perimetro();
        public string ToString();
    }
}