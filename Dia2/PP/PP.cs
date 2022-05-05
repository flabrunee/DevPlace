/*Se necesita un programa que ordene los clientes de un banco a medida 
que sacan turno del turnero. 
La manera de ordenar los turnos es primero de acuerdo a su edad: las
personas mayores de 60 años tienen prioridad sobre el resto a la vez
que se atiende primero a los mayores.
Se necesita realizar esto para los sectores de: Caja, Atencion al publico
*/
class colaBanco
{
    static void ingresonombre(Queue<string> colaApe)
    {
        bool error;
        Console.WriteLine("Ingrese apellido: ");
        do
        {
            try
            {
                colaApe.Enqueue(Console.ReadLine());
                error = false;
            }
            catch (Exception)
            {
                error = true;
                Console.WriteLine("Valor incorrecto, ingrese su apellido: ");
            }
        }
        while (error);
    }

    static void mostrarClientes(Queue<string> colaA, Queue<int> colaE)
    {
        for (int i = 0; i < colaA.Count(); i++)
        {
            Console.WriteLine("Cliente nro {0}: ", i + 1);
            Console.WriteLine(colaA.Dequeue());
            Console.WriteLine("Edad cliente {0}: ", i + 1);
            Console.WriteLine(colaE.Dequeue());
        }
    }

    static void ingresoedad(Queue<int> colaEdad)
    {
        int valor;
        Console.WriteLine("Ingrese su edad: ");
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor incorrecto, ingrese su edad: ");
            valor = 0;
        }
        colaEdad.Enqueue(Convert.ToInt32(valor));
    }

    static void Main(string[] args)
    {
        Queue<string> clientes = new Queue<string>();
        Queue<int> clientesEdad = new Queue<int>();
        const int maximoCliente = 4;
        
        for (int i = 0; i < maximoCliente; i++)
        {
            ingresonombre(clientes);
            ingresoedad(clientesEdad);
        }

        mostrarClientes(clientes, clientesEdad);
    }
}