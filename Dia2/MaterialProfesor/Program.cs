using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***************/
/*  Burbujeo   */
/***************/
namespace Burbuja
{
    class Burbuja
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("Metodo de Burbuja");
            Console.Write("Cuantos longitud del vector: ");
            string linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
        /*
        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.MetodoBurbuja();
            pv.Imprimir();
        }*/
    }
}
/***************/
/*  Quicksort  */
/***************/

namespace quicksort
{
    class QS
    {
        /*static void Main()
        {
            int n;
            Console.WriteLine("Metodo de Quick Sort");
            Console.Write("Cuantos longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            Llenar b = new Llenar(n);
        }*/
    }

    class Llenar
    {
        int h;
        int[] vector;
        public Llenar(int n)
        {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++)
            {
                Console.Write("ingrese valor {0}: ", i + 1);
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            Quicksort(vector, 0, h - 1);
            Mostrar();
        }

        private void Quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                Quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                Quicksort(vector, i, ultimo);
            }
        }

        private void Mostrar()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadLine();
        }
    }
}
/****************/
/* Recursividad */
/****************/

public class CalcularFactorial
{
    /*public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Factorial(num));
    }*/

    public static int Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}

/****************/
/*     Sort     */
/****************/

class Sort
{
    /*public static void run()
    {
        int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
        Console.WriteLine("Array Before Sorting:\n");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine("\n");
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine("Array After Sorting:\n");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }*/
}

/****************/
/*  Interfaces  */
/****************/

namespace Interfaces
{
    //Ejemplo 1 : Crear interface e implementarla

    public interface ICamara
    {
        void MostrarAppCamara();
        void TomarFotografia();
        string NombreDeFoto { get; set; }
        int CantidadDeFotos { get; set; }

    }

    public class Celulares : ICamara
    {
        public string NombreDeFoto { get; set; }

        public int CantidadDeFotos { get; set; }

        public void MostrarAppCamara()
        {
            Console.WriteLine("Mostrando App de Camara");
        }

        public void TomarFotografia()
        {
            throw new NotImplementedException();
        }
    }

    /*public class Program
    {
        public static void Main()
        {
            Celulares cel = new Celulares();
            cel.MostrarAppCamara();
        }
    }*/
}


/*static void Main(string[] args)
{
       /* Burbujeo */
 /*   Burbuja pv = new Burbuja();
    pv.Cargar();
    pv.MetodoBurbuja();
    pv.Imprimir();
    Sort.run();
 */
    /*QS*/
/*    int n;
    Console.WriteLine("Metodo de Quick Sort");
    Console.Write("Cuantos longitud del vector: ");
    n = Int32.Parse(Console.ReadLine());
    Llenar b = new Llenar(n);
*/
    /* Celulares */

    /*Celulares cel = new Celulares();
    cel.MostrarAppCamara();
    */
    /* Calcular Factorial */

/*    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Factorial(num));
*/
//}