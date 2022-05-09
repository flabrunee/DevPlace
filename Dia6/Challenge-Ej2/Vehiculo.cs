using System;

namespace Challenge_Ej2
{
    partial class Vehiculo
    {
        private bool estadoMotor;
        private int velocidad;

        public bool EstadoMotor { get => estadoMotor; set => estadoMotor = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public Vehiculo()
        {
            EstadoMotor = false;
            Velocidad = 0;
        }
    }
}
