/*Crea un programa que pida al usuario 5 números reales de doble precisión, 
 * los guarde en una cola y luego los muestre en pantalla.
 */
using System;
class cola5Numeros
{
    static void Main(string[] args)
    {
        Queue<double> numeros = new Queue<double>();

        Console.WriteLine("Ingrese 5 numeros de doble precision");
        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.Write("Ingrese numero {0} : ", i);
                numeros.Enqueue(Convert.ToDouble(Console.ReadLine()));
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        Console.Write("La lista de numeros es : ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(" {0}", numeros.Dequeue());
        }
        Console.WriteLine();
    }
}