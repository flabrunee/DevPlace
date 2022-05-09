using System;

namespace Challenge_Ej1
{
    partial class Rectangulo
    {
        public double retornarsuperficie()
        {
            return Lado1 * Lado2;
        }
        public double retornarperimetro()
        {
            return (Lado1 * 2) + (Lado2 * 2);
        }
    }
}
