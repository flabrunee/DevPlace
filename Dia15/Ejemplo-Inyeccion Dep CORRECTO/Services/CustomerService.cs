using Ejemplo_Inyeccion_Dep_CORRECTO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Inyeccion_Dep_CORRECTO.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }
        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
