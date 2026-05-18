using SistemaBancario.Modelo;
using SistemaBancario.Datos;

namespace SistemaBancario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear cliente
            Cliente cliente = new Cliente(
                txtNombre.Text,
                txtDocumento.Text
            );

            // Crear cuenta
            Cuenta cuenta = new Cuenta(
                txtCuenta.Text,
                cliente
            );

            // Guardar cliente
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Guardar(
                cliente.Nombre,
                cliente.Documento
            );

            MessageBox.Show("Datos guardados");
        }
    }
}