using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Challenge_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  {"Server=localhost;Integrated security=SSPI;database=master"
            //string cadena = "Data Source=127.0.0.1\\(localBD);Initial Catalog=Servidor; Integrated Security=True";

            public SqlConnection conectarBD = new SqlConnection("Server=localhost;Database=Servidor;Integrated Security = True");

            public conexion_BD()
            {
                conectarBD.Open();
            }

        }
    }
}