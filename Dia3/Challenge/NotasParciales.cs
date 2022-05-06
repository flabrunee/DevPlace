using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge
{
    internal class NotasParciales
    {
        protected const int MAXALUMNOS = 30;
        protected const int MAXNOTAS = 4;
        public static void MostrarNotas(List<Dictionary<int, int>> listaP)
        {
            string idAl, nota;
            foreach (var itParc in listaP)
            {
                foreach (KeyValuePair<int, int> parc in itParc)
                {
                    idAl = Convert.ToString(parc.Key);
                    nota = Convert.ToString(parc.Value);
                    Console.WriteLine("Id Alumno: " + idAl + " Nota: " + nota);

                }
            }
        }

        public static void CargaNotas(List<Dictionary<int, int>> lista)
        {
            for (int i = 0; i < MAXNOTAS; i++)
            {
                Dictionary<int, int> listaNotas = new Dictionary<int, int>();   //idAlumno, nota

                //listaParciales.ToList().ForEach(Console.WriteLine);

                for (int j = 0; j < MAXALUMNOS; j++)
                {
                    try
                    {
                        Random randnota = new Random();
                        Random randidAl = new Random();
                        int idAl = randidAl.Next(1, 12000);   //genera el idAl
                        int nota = randnota.Next(1, 10);   //genera la nota
                        if (!listaNotas.ContainsKey(idAl))   //Si no esta ingresado ese idAl...
                        {
                            listaNotas.Add(idAl, nota);   //idAlumno, Nota
                        }
                        else { j--; }   //Si ya estaba ingresado el idAl vuelve a generar la nota
                    }
                    catch
                    {
                        j--;   //Si falla por alguna razon, volver a generar carga
                    }
                }
                lista.Add(listaNotas);
                //listaNotas.Clear();   //Borra diccionario
            }
        }
        public static void OrdBurbujeo(Dictionary<int, int> listaOrd)
        {
            /*         Dictionary<int, int> listaOrd = new Dictionary<int, int>();

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
                         }*/
        }
        public static void OrdenarNotas(List<Dictionary<int, int>> lista)
        {
            foreach (var itParc in lista)
            {
                //foreach (KeyValuePair<int, int> parc in itParc)
                {
                    OrdBurbujeo(itParc);
                }
            }
        }
    }
}
