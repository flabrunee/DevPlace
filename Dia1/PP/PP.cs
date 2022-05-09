using System;

namespace PP
{
    internal class EjerciciosPP
    {
        /*Realizar la carga de 10 destinos en una matriz y calcular cuanto tiempo tarda un vehiculo en terminar el recorrido.
                  * Dada la ecuacion (d = v * t) donde d es la distancia, v es la velocidad y t el tiempo, pedir la velocidad y 
                  * calcular cuanto tiempo tarda en recorrer todos los destinos.*/
        static void Main(string[] args)
        {

            double t, v;
            int[] destinos = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese la distancia al destino {0}: ", i);
                if (!int.TryParse(Console.ReadLine(), out destinos[i]))
                {
                    Console.WriteLine("Valor incorrecto");
                    destinos[i] = 0;
                }
            }
            int sumadist = 0;
            for (int i = 0; i < 10; i++)
            {
                sumadist += destinos[i];
            }
            Console.Write("Ingrese la velocidad (km/h): ");
            string s = Console.ReadLine();
            //v = int.Parse(s);   //Con este método el compilador marca Advertencia
            v = Convert.ToInt32(s);
            t = sumadist / v;
            Console.WriteLine("El tiempo aprox. que tarda en recorrer todos los destinos es de: {0} horas", t);
            Console.ReadLine();
        }
    }
}