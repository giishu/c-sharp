using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Carrera
    {
        public IVehiculos vehiculo1;
        public IVehiculos vehiculo2;

        public Carrera(IVehiculos v1, IVehiculos v2)
        {
            vehiculo1 = v1;
            vehiculo2 = v2;
        }

        public void correr(int segundos)
        {
            vehiculo1.mover(segundos);
            vehiculo2.mover(segundos);
        }

        public void reiniciar()
        {
            vehiculo1.reiniciarPosicion();
            vehiculo2.reiniciarPosicion();
        }

        public void mostrarResultados()
        {
            Console.WriteLine("Posición vehículo 1: " + vehiculo1.posicion());
            Console.WriteLine("Posición vehículo 2: " + vehiculo2.posicion());
        }
    }
}
