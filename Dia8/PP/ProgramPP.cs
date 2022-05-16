using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Data.SqlClient;

/*Crear una base de datos llamada DevPlaceBD, q contenga dos tablas: Curso y tecnologia
Un curso contiene una tecnologia.
Ambas tablas deben tener las columnas: claves primarias y claves externas para saber 
las fecha de inicio, fin, cantidad de alumnos y tecnologia que se dicta en cada curso*/
/*
namespace PP
{
    class ProgramEjPP
    {
        
        static void Main(string[] args)
        {*/
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.Open();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            }
            catch (global::System.Exception)
            {

                throw;
            }
        /*}
    }
}*/

/*
[dbo].[Curso]
[dbo].[Tecnologia]*/