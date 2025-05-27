using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
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
}
