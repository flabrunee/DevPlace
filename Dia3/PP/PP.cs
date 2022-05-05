/*Se implementan dos clases (suma y resta) devuelven 2 valores y un resultado, las propiedades tienen un metodo operar() 
 * implementar dos clases que llamemos en este caso, Suma y Resta. Cada clase tiene como atributo valor1, valor2  y resultado. 
 * En este caso , las propiedades a definir son Valor1, Valor2 y Resultado, el método Operar (que en el caso de la clase "Suma" 
 * suma los dos Valores y en el caso de la clase "Resta" hace la diferencia entre Valor1 y Valor2.*/

/*protected int valor1;
  protected int valor2;
  protected int resultado;*/

namespace PP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            bool hayerror = true;
            do
            {
                try
                {
                    Console.Write("Ingrese un numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese otro numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Resta opResta = new Resta();
                    opResta.num1 = num1;
                    opResta.num2 = num2;
                    Console.WriteLine(opResta.Operar());
                    hayerror = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vuelva a ingresaar los datos");
                }
            } while (hayerror);
        }

    }

}