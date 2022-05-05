using System;

//int num, suma;
Console.Write("Ingresar numero de ejercicio: ");
int ej = Convert.ToInt32(Console.ReadLine());
switch (ej)
{
    case 1:   //Ejercicio 1
        {
            int num;
            do
            {
                Console.Write("Ingrese un numero: ");
                try
                {
                    //num = Convert.ToInt32(Console.ReadLine());
                    num = Console.Read();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                    num = 0;
                }
                int suma = 0;
                for (int cnt = num; cnt < num + 101; cnt++)
                    suma += cnt;
                Console.WriteLine("La suma de los 100 numeros siguientes al {0} es {1}", num, suma);
            } while (num != 0);
        }
        break;
    case 2:   //Ejercicio 2
        {
            Console.Write("Ingresar dos numeros distintos");
            Console.Write("Ingrese primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 != -1)
            {
                if (num1 != num2)
                {
                    // int menor = 0;   //Comenzar por el menor
                    for (int i = num1; i < num1 + 101; i += 7)
                    {
                        Console.WriteLine("Ingrese numeros distintos");
                    }
                }
                else
                    Console.WriteLine("Los numeros deben ser distintos.");
                Console.WriteLine();
                num2 = Convert.ToInt32(Console.ReadLine());
            }
        }
        break;
    case 3:  /*Escribe un programa que permita ir introduciendo una serie indeterminada de números 
              * mientras su suma no supere el valor de 150 Cuando esto último ocurra, se debe 
              * mostrar el total acumulado, el contador de los números introducidos y la media.*/
        {
            int suma = 0, cantidad = 0;
            int num;
            do
            {
                Console.Write("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
                cantidad++;
            } while (suma < 150);
            Console.WriteLine("La suma es: {0}", suma);
            Console.WriteLine("La cantidad de numeros es: {0}", cantidad);
            Console.WriteLine("La media es: {0}", suma / cantidad);
        }
        break;
    case 12: /* En un almacen existen multitud de artículos, sabemos que: 
              * Todos tienen un código de 7 dígitos 
              * El primer dígito indica el departamento al que pertenece. 
              * Hay 9 departamentos, por tanto se usan números del 1 al 9. 
              * El 2º y 3ª dígito indica el tipo de artículo (va del 01 al 20). 
              * Con los dígitos 4,5,6 y 7, se calcula el precio teniendo presente
              *   que éste se obtiene multiplicando el valor que representan
              *   los 4 dígitos por el número del departamento al que pertenece el 
              *   artículo, dividiendo por 100 y tomando el valor entero de ese resultado
              *   que a su vez se multiplica por una constante llamada constante de
              *   beneficio que actualmente es de 3.5. 
              * El resultado final será el precio unitario del artículo. 
              * Realiza un programa que pregunte Desea consulta? (Sí/No), 
              *   en caso afirmativo se introduce el código y en pantalla debe salir: 
              *   Departamento: Artículo: Precio: 
              * Se debe controlar la entrada de códigos erróneos.*/

        {
            const int constante_de_beneficio = 3.5;
            int[] indicearticulos = new int[5];
            string s;
            //Carga artículos
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese numero articulo {0}: ", i);
                if (!int.TryParse(Console.ReadLine(), out indicearticulos[i]))
                {
                    Console.WriteLine("Entrada incorrecta, ingresar una cifra numerica");
                    i--;
                }
                s = Console.ReadLine();

                //ind = Convert.ToInt32(s);

            }

            do
            {
                Console.WriteLine("Ingrese numero articulo: ");
                Console.ReadLine();
            } while ();
            Console.WriteLine("");
        }
        break;
    case 5:
        {

            var rand = new Random();
            double c = rand.NextDouble();
            var condition = c > 0.5;

            int? x = condition ? 12 : null;
            Console.Write(x);
        }
        break;
}