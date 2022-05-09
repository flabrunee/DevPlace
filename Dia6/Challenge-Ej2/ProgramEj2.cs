using System;
using System.Collections;


/*Crear la clase Vehículo, definir las propiedades estadoMotor, velocidad y los métodos 
 * Arrancar() , Frenar(), Acelerar() y Apagar(). Dividir la clase en distintos archivos 
 * utilizando el concepto de "partial class".*/

namespace Challenge_Ej2
{
    internal class ProgramEj2
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();
            string accion;
            do
            {
                Console.Clear();
                Console.WriteLine("Arrancar - 1");
                Console.WriteLine("Acelerar - 2");
                Console.WriteLine("Frenar   - 3");
                Console.WriteLine("Apagar   - 4");
                Console.WriteLine("Salir    - 5");
                Console.Write("Ingrese accion del vehiculo: "); accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":  //Encender
                        {
                            if (v.Arrancar()) { Console.WriteLine("Encendido"); }
                        }
                        break;
                    case "2":  //Acelerar
                        {
                            if (v.Acelerar()) { Console.WriteLine("Acelerando..."); }
                        }
                        break;
                    case "3":  //Frenar
                        {
                            if (v.Frenar()) { Console.WriteLine("Frenando..."); }
                        }
                        break;
                    case "4":  //Apagar
                        {
                            if (v.Apagar()) { Console.WriteLine("Apagado"); }
                        }
                        break;
                    case "5": { } break;
                    default:
                        {
                            Console.WriteLine("Opcion incorrecta");
                        }
                        break;
                }
                Console.ReadKey();
            } while (accion != "5");
        }
    }
}