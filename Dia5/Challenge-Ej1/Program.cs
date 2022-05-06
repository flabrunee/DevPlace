namespace Challenge_Ej1
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            bool sigue = true;
            string op;

            do
            {
                try
                {
                    Console.Write("Ingresar numero de ejercicio 1,2,...0 -> sale : ");
                    op = Console.ReadLine();
                    const int CANTPERS = 3;

                    Persona[] arregloPersonas = new Persona[CANTPERS];
                    for (int i = 0; i < CANTPERS; i++)
                    {
                        Console.WriteLine("Ingresar nombre de la persona {0}", i + 1);
                        string nombre = Console.ReadLine();
                        //Persona pers = new Persona(nombre) { Nombre = nombre; };
                        //arregloPersonas[i] = pers;
                    }
                    //Mostrar
                    for (int i = 0; i < CANTPERS; i++) { Console.WriteLine(arregloPersonas.ToString()); }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            } while (sigue);
        }
    }
}