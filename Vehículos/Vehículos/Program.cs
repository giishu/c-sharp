using System;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat = new Auto(45); // El auto se mueve a 45 mts por segundo
            Bicicleta bici = new Bicicleta();
            Auto auto = new Auto();
            Camion camion = new Camion();
            bici.mover(20); // Mover la bicicleta durante 20 segundos
            Console.WriteLine(bici.posicion()); // Mostrar la posición de la bicicleta
            bici.mover(10); // Mover la bicicleta durante otros 10 segundos más
            Console.WriteLine(bici.posicion()); // Mostrar la posición nueva de la bicicleta

            Carrera carrera = new Carrera(auto, bici);

            auto.reiniciarPosicion();
            bici.reiniciarPosicion();

            carrera.correr(10); // correr 10 segundos
            carrera.mostrarResultados();

        }
    }
}
