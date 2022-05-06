namespace Challenge_Ej3
{
    internal class Program
    {
        static void mensaje()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
           //Console.WriteLine("  <----- Metodo sobrecargado de clase Ubicacion");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static double truncar(double d)
        {
            return (Math.Truncate(d * 100)) / 100;
        }

        static void Main(string[] args)
        {
            bool sigue = true;
            string op;

            do
            {
                try
                {
                    Console.WriteLine("RECTANGULO");
                    Console.Write("Ingresar base: "); int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresar altura: "); int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresar posicion x: "); int xr = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresar posicion y: "); int yr = Convert.ToInt32(Console.ReadLine());
                    Rectangulo rect = new(b, a, xr, yr);

                    Console.WriteLine("CIRCULO");
                    Console.Write("Ingresar radio: "); int r = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresar posicion x: "); int xc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresar posicion y: "); int yc = Convert.ToInt32(Console.ReadLine());
                    Circulo circ = new(r, xc, yc);

                    Console.WriteLine();
                    Console.Write(rect.ToString()); mensaje();
                    Console.WriteLine("El área del rectangulo es : " + rect.Area() + "\r\nEl perímetro del rectangulo es : " + rect.Perimetro() + "\r\n");

                    Console.Write(circ.ToString()); mensaje();
                    Console.WriteLine("El área del circulo es : " + truncar(circ.Area()) + "\r\nEl perímetro del circulo es: " + truncar(circ.Perimetro()) + "\r\n");

                    Console.WriteLine();
                    Console.Write("Continua? (n termina) :");
                    sigue = (Console.ReadLine() != "n");
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            } while (sigue);
        }
    }
}