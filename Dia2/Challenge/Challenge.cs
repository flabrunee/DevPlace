using System.IO;
using System.Collections.Generic;
using System;

class ReadingCSV
{
    static void Main(string[] args)
    {
        var reader = new StreamReader(File.OpenRead(@"F:\Data.csv"));
        List<string> listA = new List<string>();
        List<string> listB = new List<string>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();  //Pedro;24;23.654.643
            var values = line.Split(';');  // [Pedro] [24] [23.654.643]

            listA.Add(values[0]);  //Nombre
            listB.Add(values[1]);  //Edad
            //listDNI.Add(values[2]);
        }
        foreach (var coloumn1 in listA)
        {
            Console.WriteLine(coloumn1);
        }
        foreach (var coloumn2 in listB)
        {
            Console.WriteLine(coloumn2);
        }
    }
}

/*- Se tiene las notas de 4 parciales tomados a 30 alumnos ordenados en forma creciente 
 * por NRO DE ALUMNO. El nro de alumno es un valor entero entre 1 y 12000. 
 * Se desea ingresar un NRO DE ALUMNO y buscarlo por medio de la búsqueda dicotómica 
 * dentro del arreglo. Si se encuentra, dar el nro de alumno junto con las notas de 
 * los 4 parciales; sino exhibir cartel aclaratorio.*/

//var sortedDict = from entry in myDict orderby entry.Value ascending select entry;