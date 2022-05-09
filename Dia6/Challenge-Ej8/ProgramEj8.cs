using System;
/*EXTENSION*/


/*Agregar dos métodos a la clase string que permitan recuperar la primera mitad y la segunda mitad de la cadena.*/

namespace Challenge_Ej8
{
    static class ExtensionString
    {
        public static string primeraMitad(this string cadena)
        {
            int mitad = cadena.Length / 2;
            return (cadena.Substring(0, mitad)).ToString();
        }
        public static string segundaMitad(this string cadena)
        {
            double mitad = cadena.Length / 2;
            double indice = Math.Truncate( mitad);
            return cadena.Substring(Convert.ToInt32(indice)).ToString();
        }
    }
    internal class ProgramEj8
    {
        static void Main(string[] args)
        {
            string cadena;
            do
            {
                Console.Write("Ingrese el texto ('salir' -> termina): "); cadena = Console.ReadLine();
                try
                {
                    Console.WriteLine(cadena.primeraMitad());
                    Console.WriteLine(cadena.segundaMitad());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e);
                }
            } while (cadena != "salir");
        }
    }

}
