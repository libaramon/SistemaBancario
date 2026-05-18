using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPracticoSistemaBancario
{
    internal class Cliente
    {
        // Propiedad de solo lectura
        // Una vez creado el cliente, su nombre no debería cambiar
        public string Nombre { get; }
        public string Documento { get; }

        // Constructor
        // Obliga a crear un cliente con datos válidos
        public Cliente(string nombre, string documento)
        {
            Nombre = nombre;
            Documento = documento;
        }
    }
}
