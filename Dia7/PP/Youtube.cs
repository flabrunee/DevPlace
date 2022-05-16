using System;

namespace PP
{
    public class Youtube : ISuscriptor
    {
        private string nombreUsuario;
        public string NombreUsuario { get { return nombreUsuario; } }
        public Youtube(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public void actualizar(double temperatura)
        {
            Console.WriteLine("temperatura: " + temperatura + "\nse ha recibido la actualizacion por youtube " + this.nombreUsuario);
        }
    }
}
