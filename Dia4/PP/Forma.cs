using System;

namespace PP
{
    internal interface Forma
    {
        public Ubicacion ubicacion { get; set; }
        public double Area();
        public double Perimetro();
        public string ToString();
    }
}