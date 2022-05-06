namespace Challenge_Ej3
{
    internal class Rectangulo : Forma
    {
        protected double lado1 { get; set; }
        protected double lado2 { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Rectangulo(int lado1, int lado2, int posx, int posy)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.ubicacion = new Ubicacion(posx, posy);
        }
        public double Area() { return lado1 * lado2; }
        public double Perimetro() { return lado1 * 2 + lado2 * 2; }
        public string ToString()
        {
            return "Coordenadas del rectangulo: " + ubicacion.ToString();
        }
    }
}
