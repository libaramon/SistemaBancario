using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPracticoSistemaBancario
{
    internal class Cuenta
    {
        // Número de cuenta: no debe cambiar
        public string NumeroCuenta { get; }

        // El saldo solo puede modificarse desde la clase
        public double Saldo { get; private set; }

        //Relación: una cuenta pertenece a un cliente
        public Cliente Titular { get; }

        //Constructor
        public Cuenta(string numeroCuenta, Cliente titular)
        {
            NumeroCuenta = numeroCuenta;
            Titular = titular;
            Saldo = 0; // Toda cuenta inicia en cero
        }

        //// Método de instancia: deposita dinero
        public void Depositar(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto a depositar debe ser mayor a cero.");
                return;
            }

            Saldo += monto;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: {Saldo:C2}");
        }


        // Método de instancia: retira dinero
        public void Retirar(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero.");
                return;
            }

            if (monto > Saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
                return;
            }

            Saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Nuevo saldo: {Saldo:C2}");
        }
    }
}
