/* Crea un programa en C# que solicite tres nombres de personas al usuario y los almacene en un 
 * array de objetos de tipo Persona. Habrán dos personas de tipo Estudiante y una persona de tipo Profesor.
 * Para ello crea una clase Persona que tenga una propiedad Nombre de tipo string, un constructor que reciba 
 * el nombre como parámetro y sobrescriba el método ToString().
 * Después cree dos clases más que hereden de la clase Persona, se llamarán Estudiante y Profesor. 
 * La clase Estudiante tiene un método Estudiar que escribe por consola que el estudiante está estudiando. 
 * La clase Profesor tendrá un método Explicar que escribe en consola que el profesor está explicando. 
 * Recuerde crear además dos constructores en las clases hijas que llamen al constructor padre de la clase Persona. 
 * Finalice el programa leyendo las personas (el profesor y los alumnos) y ejecute los métodos de Explicar y Estudiar.*/

namespace Challenge_Ej2
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
                {/*
                    Console.Write("Ingresar nombre #1 ");
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

                    Console.Write("Continua? n -> sale : ");
                    op = Console.ReadLine();
                    sigue = (op != "n");*/
                    Estudiante estudiante4;
                    Profesor profesor3;
                    Persona estudiante2 = new Estudiante(19, "Juanito");
                    Persona estudiante3 = new Estudiante(20, "Juan");
                    Persona profesor2 = new Profesor(40, "Juanpi");
                    Persona[] personas = new Persona[3];
                    personas[0] = estudiante2;
                    personas[1] = estudiante3;
                    personas[2] = profesor2;
                    int i = 0;

                    Type t;
                    while (i < personas.Length)
                    {
                        t = personas[i].GetType();
                        if (t.Equals(typeof(Estudiante)))
                        {
                            estudiante4 = (Estudiante)personas[i];
                            estudiante4.estudiar();
                        }
                        else
                        {
                            profesor3 = (Profesor)personas[i];
                            profesor3.explicar();
                        }
                        i++;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            } while (sigue);
        }
    }
}