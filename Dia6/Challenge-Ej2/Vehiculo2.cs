using System;

namespace Challenge_Ej2
{
    partial class Vehiculo
    {   
        public bool Arrancar()
        {
            if (!EstadoMotor)   //Si esta apagado
            {
                EstadoMotor = true;
                return true;
            }
            return false;   //Si ya estaba prendido devuelve falso
        }        
        public bool Acelerar()
        {
            if (EstadoMotor)   //Si esta encendido
            {
                Velocidad += 10;
                return true;
            }
            return false;
        }
        public bool Frenar()
        {
            if ((EstadoMotor) && (Velocidad > 0))   //Si esta encendido y moviendose
            {
                Velocidad -= 10;
                return true;
            }
            return false;
        }
        public bool Apagar()
        {
            if (EstadoMotor && (Velocidad == 0))   //Si está encendido y sin moverse
            {
                EstadoMotor=false;
                return true;
            }
            return false;
        }
    }
}
