using System;

namespace CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(123, 1000, "Juan Pérez");
            CuentaBancaria cuenta2 = new CuentaBancaria(456, 500, "Ana López");

            Banco banco = new Banco();

            Console.WriteLine("Saldo inicial de Juan: $" + cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo inicial de Ana: $" + cuenta2.obtenerSaldo());

            banco.depositar(cuenta1, 200);
            Console.WriteLine("Juan deposita $200. Saldo actual: $" + cuenta1.obtenerSaldo());

            banco.extraer(cuenta2, 100);
            Console.WriteLine("Ana extrae $100. Saldo actual: $" + cuenta2.obtenerSaldo());

            Console.WriteLine("Juan transfiere $500 a Ana.");

            bool exito = banco.transferencia(cuenta1, cuenta2, 500);
            Console.WriteLine(exito ? "Transferencia exitosa." : "Transferencia fallida.");

            Console.WriteLine("Saldo final de Juan: $" + cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo final de Ana: $" + cuenta2.obtenerSaldo());
        }
    }
}
