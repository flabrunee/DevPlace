using System;
//COMO PASAR PARAMETROS POR REFERENCIA   => static bool VerificarCodigo(int[] vector, int indice)   //Pasar el vector (por referencia) y el indice actual para poder modificar el original y devolver el valor
//PERTENENCIA A UN RANGO. in [0..9] ['a'..'f']... => CodDeptoOk
/*int[] j = { 1 };
  if (j is [0,_,9])   //La característica "patrón de lista" se encuentra actualmente en vista previa y *no se admite*. Para usar características en vista previa, utilice la versión de idioma "vista previa".
      Console.WriteLine("Si");*/
//EXPRESIONES LAMBDA => CodDeptoOk
//CONVERTIR CHAR A INT (ObtDepto)

namespace Challenge
{
    internal class Program {
        //Ejercicio 12: Devuelve el Departamento del articulo. Devuelve string[1]
        static int ObtDepto(string codart)
        {
            char aux = codart[0];
            int integer = int.Parse(aux.ToString()); 
            return integer;
        }
        //Ejercicio 12: Devuelve el Tipo de articulo. Devuelve string[2]
        static string ObtTipoArt(string codart)
        {
            return "" + codart[1] + codart[2];
        }
        //Ejercicio 12: Devuelve el precio inicial del articulo. Devuelve string[4]
        static int ObtPrecioArt(string codart)
        {
            return Convert.ToInt32("" + codart[3] + codart[4] + codart[5] + codart[6]);
        }
        //static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        static bool CodDeptoOk(int c) => c is >= '1' and <= '9';
        static bool CodTipoArtOk(int c) => c is >= 1 and <= 20;
        static bool VerificarCodigo(string codstr)
        {
            bool resultado = true;
            if (!int.TryParse(codstr, out _))
            {
                resultado = false;
                Console.WriteLine("Entrada incorrecta, ingresar una cifra ");
            }
            //Ya sabemos que son todos digitos, ahora hay que verificar el largo y los campos
            
            //Largo de 7 digitos?
            if (codstr.Length != 7) { resultado = false; Console.WriteLine("Tamaño de codigo incorrecto, ingresar cifra de 7 digitos"); }
            else
            {   //Verificar dominio campos
                //Departamento
                if (!CodDeptoOk(codstr[0]))
                {
                    resultado = false;
                    Console.WriteLine("Codigo de departamento incorrecto, ingrese (0-9)");
                }
                //Tipo
                if (!CodTipoArtOk(Convert.ToInt32("" + codstr[1] + codstr[2])))
                {
                    resultado = false;
                    Console.WriteLine("Codigo de tipo de articulo incorrecto, ingrese (01-20)");
                }
            }
            return resultado;
        }
        static int Buscar_indice_art(string codigo, int[] vector) {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == Convert.ToInt32(codigo))
                {
                    return i;   //Si lo encontró
                }
            }
            return -1;   //Si no lo encontró
        }
        static void Main(string[] args) {
            string op;
            do
            {
                Console.Write("Ingresar numero de ejercicio: ");
                int ej = Convert.ToInt32(Console.ReadLine());
                switch (ej)
                {
                    case 1:   //Ejercicio 1
                        /*Realiza un programa que sume los 100 números siguientes a un número entero y positivo 
                         * introducido por teclado. Se debe comprobar que el dato introducido es correcto*/
                        {
                            int num;
                            do
                            {
                                Console.Write("Ingrese un numero: ");
                                try
                                {
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
                        /* Escribe un programa que obtenga los números enteros comprendidos entre dos números 
                         * introducidos por teclado y validados como distintos, el programa debe empezar por 
                         * el menor de los enteros introducidos e ir incrementando de 7*/
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
                            const double CTE_BENEFICIO = 3.5;
                            const int MAX_ARTICULOS = 5;
                            int[] vectorArticulos = new int[MAX_ARTICULOS];
                                                            /*Como el codigo de depto no puede ser 0 entonces se pueden almacenar 
                                                             * los codigos como un arreglo de enteros sino tendria que ser de tipo 
                                                             * string porque se perderia el primer digito por ser 0*/
                            //-----Carga artículos-----
                            for (int i = 0; i < MAX_ARTICULOS; i++)
                            {   //Lectura de codigo
                                Console.Write("Ingrese código articulo {0}: ", i + 1);
                                string codstr = Console.ReadLine();
                                while (!VerificarCodigo(codstr))
                                {
                                    Console.Write("Vuelva a ingresar el codigo por favor:");
                                    codstr = Console.ReadLine();
                                }
                                //Despues de verificar todo convierte el indice sin problemas y lo asigna al vector
                                vectorArticulos[i] = Convert.ToInt32(codstr);
                            }   //Carga realizada
                            //-----Hacer consultas-----
                            int indice;
                            string sigue;
                            do
                            {
                                try
                                {
                                    int cantidad_Art = vectorArticulos.Length;   //Cantidad articulos en el vector
                                    Console.Write("Ingrese numero de artículo a consultar :");
                                    string codstr = Console.ReadLine();
                                    while (!VerificarCodigo(codstr))
                                    {
                                        Console.WriteLine("Vuelva a ingresar codigo de artículo a consultar :");
                                        codstr = Console.ReadLine();
                                    }
                                    //Busca el indice donde esta el artículo para poder operarlo
                                    indice = Buscar_indice_art(codstr, vectorArticulos);   //Lo q esta almacenado en vectorCodigos[indice] es el mismo codigo
                                                                                           //que utilice para buscarlo. O sea, vectorCodigos[indice] = codstr
                                                                                           //Obtener el precio unitario del articulo
                                    double precio = ObtPrecioArt(Convert.ToString(vectorArticulos[indice]));  // codstr);                                    
                                    double dpto = ObtDepto(Convert.ToString(vectorArticulos[indice]));        // codstr);
                                    double precio_Unitario = Math.Truncate(precio * dpto / 100) * CTE_BENEFICIO;
                                    //-----Devolver resultados-----
                                    Console.WriteLine("Departamento: " + dpto);
                                    Console.WriteLine("Articulo    : " + ObtTipoArt(Convert.ToString(vectorArticulos[indice])));  //codstr));
                                    Console.WriteLine("Precio      : " + precio_Unitario);
                                }catch (Exception ex) 
                                {
                                    Console.WriteLine(ex.ToString());
                                }
                                Console.Write("Desea volver a consultar? ('n' -> termina) : ");
                                sigue = Console.ReadLine();
                            }while (sigue != "n") ;
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

                Console.Write("Continua con el menu principal? ('n' --> salir)"); op = Console.ReadLine();
            } while (op!="n");

        }
    }
}