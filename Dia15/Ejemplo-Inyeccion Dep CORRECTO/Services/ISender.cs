using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Inyeccion_Dep_CORRECTO.Services
{
    public interface ISender
    {
        public void Send(Customer customer, string message)
        {
            Console.WriteLine($"Message sent to {customer.Name} by email");
        }
    }
}
