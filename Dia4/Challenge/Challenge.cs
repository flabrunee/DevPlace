namespace Challenge
{
    internal class Program
    {
        static void Ejercicio1()
        {
            const int CANTPERS = 3;
            /*Crea un programa en C# que solicite tres nombres de personas al usuario y los almacene 
             * en un array de objetos de tipo Persona. Para ello primero crea una clase Persona que 
             * tenga una propiedad Nombre de tipo string y sobrescriba el método ToString(). Finalice 
             * el programa leyendo las personas y ejecutando en pantalla el método ToString().*/
            Persona[] arregloPersonas = new Persona[CANTPERS];
            for (int i = 0; i < CANTPERS; i++)
            {
                Console.WriteLine("Ingresar nombre de la persona {0}", i+1);
                string nombre = Console.ReadLine();
                //Persona pers = new Persona(nombre) { Nombre = nombre; };
                //arregloPersonas[i] = pers;
            }
            //Mostrar
            for (int i = 0; i < CANTPERS; i++) { Console.WriteLine(arregloPersonas.ToString()); }
        }
        static void Main(string[] args)
        { 
            bool sigue = true;
            string op;

            do
            {
                try
                {
                    Console.Write("Ingresar numero de ejercicio 1,2,...0 -> sale : ");
                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "1": {Ejercicio1();} break;
                        case "2": { } break;
                        case "0": { sigue = false; } break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }while(sigue);
        }
    }
}