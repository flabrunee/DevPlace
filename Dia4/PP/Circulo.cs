using System;

namespace PP
{
    internal class Circulo: Forma
    {
        public double radio { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Circulo(double radio, int posx, int posy) 
        {
            this.radio = radio;
            this.ubicacion = new Ubicacion(posx,posy);
        }
        public double Area() { return Math.Pow(Math.PI * radio,2); }
        public double Perimetro() { return 2 * Math.PI * radio; }
        public string ToString()
        {
            return "Coordenadas del circulo : " + ubicacion.ToString();
        }
    }
}
