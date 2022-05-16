using System;

namespace PP
{
    internal class Clima
    {
        public double temperatura;
        private int humedad;
        public int Humedad { get => humedad; }
        public double Temperatura { get => temperatura; }
        public Clima(double temperatura, int humedad)
        {
            this.temperatura = temperatura;
            this.humedad = humedad;
        }
    }
}
