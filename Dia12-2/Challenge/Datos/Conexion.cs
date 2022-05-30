namespace Challenge.Datos
{
    public class Conexion
    {
        public string cadenaSQL = string.Empty;
        public Conexion()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json"); //Crea la BD en el directorio del proyecto
            var builder= configurationBuilder.AddJsonFile("appsettings.Development.json",optional:true).Build();
            cadenaSQL = builder.GetSection("connection:cadenaConexion").Value;
        }
        public string getConexion()
        {
            return cadenaSQL;
        }
    }
}
