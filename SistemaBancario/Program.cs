//Crear un cliente
using EjercicioPracticoSistemaBancario;

Cliente cliente1 = new Cliente(
    nombre: "Ana Gómez",
    documento: "CC123456"
);

//// Crear una cuenta asociada al cliente
Cuenta cuenta1 = new Cuenta(
    numeroCuenta: "0001-ABC",
    titular: cliente1
);

//// Mostrar información inicial
Console.WriteLine("======DATOS DE LA CUENTA========");
Console.WriteLine($"Titular: {cuenta1.Titular.Nombre}");
Console.WriteLine($"Documento: {cuenta1.Titular.Documento}");
Console.WriteLine($"Número de cuenta: {cuenta1.NumeroCuenta}");
Console.WriteLine($"Saldo inicial: {cuenta1.Saldo:C2}");
Console.WriteLine();

//// Operaciones bancarias
cuenta1.Depositar(1000);
cuenta1.Retirar(300);
cuenta1.Retirar(1000); // Intento inválido

Console.WriteLine();
Console.WriteLine($"Saldo final: {cuenta1.Saldo:C2}");