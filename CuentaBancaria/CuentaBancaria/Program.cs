using System;

namespace CuentaBancaria
{
    public class CuentaBancaria
    {
        private int numeroCuenta;
        private float saldo;
        private string titular;

        public CuentaBancaria(int numeroCuenta, float saldo, string titular)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.titular = titular;
        }

        public float obtenerSaldo()
        {
            return saldo;
        }

        public void modificarSaldo(float nuevoSaldo)
        {
            saldo = nuevoSaldo;
        }
    }
    public class Banco
    {
        public void depositar(CuentaBancaria cuenta, float cantidad)
        {
            if (cantidad > 0)
            {
                float nuevoSaldo = cuenta.obtenerSaldo() + cantidad;
                cuenta.modificarSaldo(nuevoSaldo);
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor a 0");
            }
        }

        public void extraer(CuentaBancaria cuenta, float cantidad)
        {
            if (cantidad > 0 && cuenta.obtenerSaldo() >= cantidad)
            {
                float nuevoSaldo = cuenta.obtenerSaldo() - cantidad;
                cuenta.modificarSaldo(nuevoSaldo);
            }
            else
            {
                Console.WriteLine("La cantidad a extraer debe ser mayor a 0 y no puede superar el saldo de la cuenta");
            }
        }

        public bool transferencia(CuentaBancaria cuentaOrigen, CuentaBancaria cuentaDestino, float cantidad)
        {
            if (cuentaOrigen.obtenerSaldo() < cantidad)
            {
                return false;
            }
            else
            {
                extraer(cuentaOrigen, cantidad);
                depositar(cuentaDestino, cantidad);
                return true;
            }
        }
    }
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
