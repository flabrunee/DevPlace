using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Inyeccion_Dep_CORRECTO.Repositories
{
    public class CustomerRepository
    {
        private MySQLConnection _connection;

        public CustomerRepository()
        {
            _connection = new MySQLConnection();
        }
        public List<Customer> GetCustomers()
        {
            if (_connection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get Customers from MySQL");

            return new List<Customer>()
            {
                new Customer() {Id=1,Name="John Wick", Email="john@wick.com", Phone = "0232323324"},
                new Customer() {Id=2,Name="Clint Eastwood", Email="clint@ew.com",Phone="3434324324"}
            };
        }
    }
}
