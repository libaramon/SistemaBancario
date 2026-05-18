using System.Data.SqlClient;
using EjercicioPracticoSistemaBancario;

namespace SistemaBancario.Datos
{
    internal class CuentaDAO
    {
        Conexion conexion = new Conexion();

        public void Guardar(Cuenta cuenta, int clienteId)
        {
            SqlConnection con = conexion.ObtenerConexion();

            string query = @"
                INSERT INTO Cuenta
                (NumeroCuenta, Saldo, ClienteId)
                VALUES
                (@numero, @saldo, @clienteId)
            ";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@numero", cuenta.NumeroCuenta);
            cmd.Parameters.AddWithValue("@saldo", cuenta.Saldo);
            cmd.Parameters.AddWithValue("@clienteId", clienteId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}