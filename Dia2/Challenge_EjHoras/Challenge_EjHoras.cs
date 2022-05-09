using System.IO;
using System.Collections.Generic;
using System;
/*La empresa GoogleMar dispone del archivo secuencial PERSONAL.csv con los siguientes datos de cada uno de 
 *  sus 175 operarios activos.
●	Nro. de Legajo (Nro. entero de 3 cifras NO correlativo)
●	Apellido y Nombres (80 caracteres)
●	Valor Hora(xx.xx)
●	Total de horas trabajadas (actualizar sumando)
●	Total de sueldos a cobrar a la Fecha (actualizar sumando)
●	Fecha del último proceso ( dia-mes-año) (actualizar cambiando)

Confeccionar el diagrama de lógica y la respectiva codificación para:

1.Generar un vector llamado ArrayPersona con los datos existentes en el archivo PERSONAL.csv, utilizando la 
    función LECTURA_PERSONAL.

2.	Ingresar desde el teclado la fecha del día de proceso: 
    a.día(1 a 30), mes(1 a 12) y año(2011 a 2013 inclusive). 
    b.Solo permitir el ingreso de una fecha correcta, por error volver a solicitar toda la fecha. 
    c.Confeccionar la función LEECONTROL para tal fin.

3.	También se dispone del archivo HORAS.csv donde por cada día trabajado se registró:
	-Nro. de Legajo (Nro. entero de 3 cifras NO correlativo)
    -Cantidad de horas trabajadas 
	Estos datos se encuentran en el archivo ordenados por legajo.
4.	Para el control de la existencia del Nro. de Legajo confeccionar la función BUSQUEDA con los argumentos necesarios. 
    Si no existe, grabar la información ingresada (Nro. de legajo cantidad de horas trabajadas) en el archivo ERROR.dat.
5.	Actualizar ArrayPersona con las novedades ingresadas 
6.	El importe a cobrar se calcula como el producto entre las horas trabajadas y el valor que cobra por hora el operario.
    La fecha de proceso es la ingresada por teclado.
*/
/* Convenciones: 
 * -Total de horas trabajadas (actualizar sumando). Asumo que se refiere a tener un solo registro por operario cargado 
 *  en el arreglo y cuando se encuentra otro legajo ya ingresado en el cvs se actualizan la cantidad de horas, sueldo 
 *  y fecha del ultimo proceso en el arreglo.
 *  
 */

namespace Challenge_EjHoras
{
    internal class Program
    {
        const int MAXARRAY = 8;
        static void LecturaPersonal(Operario[] lista_oper)
        {
            var reader = new StreamReader(File.OpenRead(@"F:\Personal.csv"));
            Operario op;
            string legajo, apynom;
            double valorhora, TotaHrsTrab, TotSueldoACobrar;
            DateTime fecha;
            int indice = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();  //Pedro;24;23.654.643
                var values = line.Split(';');  // [Pedro] [24] [23.654.643]
                //Levantar linea del archivo
                legajo = values[0];
                apynom = values[1];
                valorhora = values[2];
                TotaHrsTrab = Convert.ToDouble(values[3]);
                TotSueldoACobrar = Convert.ToDouble(values[4]);
                fecha = DateTime.Parse(values[5]);
                //Crear operario y cargar los datos
                op = new Operario(legajo, apynom, valorhora, TotaHrsTrab, TotSueldoACobrar, fecha);
                //Agregar operario a la lista
                lista_oper[indice] = op;
            }
        }

        static void LeerControl()
        {
            var reader = new StreamReader(File.OpenRead(@"F:\Horas.csv"));
            Hora_trabajada hrTrb;
            string legajo;
            double TotaHrsTrab;
            while (!reader.EndOfStream)
            {
                hrTrb = new Hora_trabajada();
            }

        static void Main(string[] args)
        {
            //List<Operario> lista_oper = new List<Operario>();
            Operario[MAXARRAY] ArrayPersonas = new Operario();

            lista_oper.Equals()
            //foreach (string line in Console.ReadLine().Split(new char[] { }))


        }
    }
}
//var sortedDict = from entry in myDict orderby entry.Value ascending select entry;