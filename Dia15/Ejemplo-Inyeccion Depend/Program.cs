using Ejemplo_Inyeccion_Depend.Services;
using System;

namespace Ejemplo_Inyeccion_Depend
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();

            var message = "Message to broadcast to all customers";

            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer, message);
            }
        }
    }
}