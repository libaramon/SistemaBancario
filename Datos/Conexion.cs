using System.Data.SqlClient;

namespace SistemaBancario.Datos
{
    public class Conexion
    {
        private string cadena =
            "Server=localhost;Database=BancoDB;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}