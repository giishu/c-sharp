using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
