using Challenge.Models;
using System.Data;
using System.Data.SqlClient;

namespace Challenge.Datos
{
    public class ClienteDatos
    {
        public List<ClienteModel> Listar()
        {
            var lista = new List<ClienteModel>();
            var conex = new Conexion();
            using (SqlConnection conexion = new SqlConnection(conex.getConexion()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE", conexion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClienteModel model = new ClienteModel();
                        model.Id = reader.GetInt32("Id");
                        model.Nombre = reader.GetString("Nombre");
                        model.Apellido = reader.GetString("Apellido");
                        model.DNI = reader.GetString("DNI");
                        model.Direccion = reader.GetString("Direccion");
                        lista.Add(model);
                    }
                }
                conexion.Close();
                return lista;
            }
        }
        public ClienteModel GetIdCliente(int id)
        {
            var cliente = new ClienteModel();
            var conex = new Conexion();
            using (var conexion = new SqlConnection(conex.getConexion()))
            {
                conexion.Open();
                string sql = $"SELECT * FROM CLIENTE WHERE Id = '{id}'";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente.Id = reader.GetInt32("Id");
                        cliente.Nombre = reader.GetString("Nombre");
                        cliente.Apellido = reader.GetString("Apellido");
                        cliente.DNI = reader.GetString("DNI");
                        cliente.Direccion = reader.GetString("Direccion");
                    }
                }
                conexion.Close();
                return cliente;
            }
        }
    }
}
