using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ChallengeDia11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (EntityFramework db = new EntityFramework())
            {
                var l= db.
            }*/
            string connectionstr;
            Venta[] ventas;
            SqlConnection cnn;
            connectionstr = @"data source=(localdb)\devplace;initial catalog=ChallengeDia9-Ej3-Concesionaria;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            cnn = new SqlConnection(connectionstr);
        }
    }
}
