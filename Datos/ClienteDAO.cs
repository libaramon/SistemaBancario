using System.Data.SqlClient;

namespace SistemaBancario.Datos
{
    public class ClienteDAO
    {
        Conexion conexion = new Conexion();

        public void Guardar(string nombre, string documento)
        {
            SqlConnection con = conexion.ObtenerConexion();

            string query =
                "INSERT INTO Cliente(Nombre, Documento) VALUES(@n,@d)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@d", documento);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}