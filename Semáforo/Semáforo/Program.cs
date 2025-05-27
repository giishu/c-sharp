using System;

namespace Semaforo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaforo semaforo = new Semaforo("Amarillo");

            Console.WriteLine($"Tiempo: 0 segundos, Color: {semaforo.mostrar_Color()}");

            for (int i = 1; i <= 60; i++)
            {
                semaforo.paso_Del_Tiempo(1);
                Console.WriteLine($"Tiempo: {i} segundos, Color: {semaforo.mostrar_Color()}");
            }

            Console.WriteLine("\n--- Cambiando a modo intermitente ---\n");
            semaforo.poner_En_Intermitente();
            for (int i = 61; i <= 70; i++)
            {
                semaforo.paso_Del_Tiempo(1);
                Console.WriteLine($"Tiempo: {i} segundos, Color: {semaforo.mostrar_Color()}");
            }

            Console.WriteLine("\n--- Saliendo de modo intermitente ---\n");
            semaforo.quitar_Intermitente();
            Console.WriteLine($"Tiempo: 71 segundos, Color: {semaforo.mostrar_Color()}");

            for (int i = 72; i <= 131; i++)
            {
                semaforo.paso_Del_Tiempo(1);
                Console.WriteLine($"Tiempo: {i} segundos, Color: {semaforo.mostrar_Color()}");
            }
        }
    }
}