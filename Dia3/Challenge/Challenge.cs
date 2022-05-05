using System.IO;
using System.Collections.Generic;
using System;
//using Challenge;
/*Se tiene las notas de 4 parciales tomados a 30 alumnos ordenados en forma creciente por NRO DE ALUMNO. 
 * El nro de alumno es un valor entero entre 1 y 12000. Se desea ingresar un NRO DE ALUMNO y buscarlo 
 * por medio de la búsqueda dicotómica dentro del arreglo. Si se encuentra, dar el nro de alumno 
 * junto con las notas de los 4 parciales; sino exhibir cartel aclaratorio.*/
//Las notas son del 1 al 10

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<int, int>> listaParciales = new List<Dictionary<int, int>>();   //Listas de Parciales

            NotasParciales.CargaNotas(listaParciales);
            NotasParciales.OrdenarNotas(listaParciales);
            NotasParciales.MostrarNotas(listaParciales);
        }
    }
}