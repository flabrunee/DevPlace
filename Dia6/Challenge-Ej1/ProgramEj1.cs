using System;
/*-Crear la clase Rectángulo, definir dos propiedades: Lado1 y Lado2. Definir dos métodos RetornarSuperficie 
 * y RetornarPerimetro. Dividir la clase en dos archivos utilizando el concepto de "partial class".*/

namespace Challenge_Ej1
{
    internal class ProgramEj1
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();

            Console.Write("Ingrese medida lado 1 :"); rect.Lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese medida lado 2 :"); rect.Lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La superficie es: " + rect.retornarsuperficie());
            Console.WriteLine("El perimetro es: " + rect.retornarperimetro());
        }
    }
}