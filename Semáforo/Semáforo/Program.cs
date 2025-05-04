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

    public class Semaforo
    {
        public string color_actual;
        public int tiempo_actual;
        public bool intermitente;
        public bool amarillo_int;

        public Semaforo(string color_inicial)
        {
            intermitente = false;
            amarillo_int = true;

            switch (color_inicial)
            {
                case "Rojo":
                    tiempo_actual = 0;
                    break;
                case "Rojo-Amarillo":
                    tiempo_actual = 30;
                    break;
                case "Verde":
                    tiempo_actual = 32;
                    break;
                case "Amarillo":
                    tiempo_actual = 52;
                    break;
                default:
                    tiempo_actual = 0;
                    color_inicial = "Rojo";
                    break;
            }
            color_actual = color_inicial;

        }

        public void paso_Del_Tiempo(int segundos)
        {
            if (intermitente)
            {
                if (segundos > 0)
                {
                    amarillo_int = !amarillo_int;
                }
                return;
            }
            tiempo_actual += segundos;

            int tiempo = tiempo_actual % 54;

            if (tiempo < 30)
                color_actual = "Rojo";
            else if (tiempo < 32)
                color_actual = "Rojo-Amarillo";
            else if (tiempo < 52)
                color_actual = "Verde";
            else
                color_actual = "Amarillo";
        }

        public string mostrar_Color()
        {
            if (intermitente)
            {
                if (amarillo_int)
                    return "Amarillo Intermitente";
                else
                    return "Apagado";
            }
            else
            {
                return color_actual;
            }
        }
        public void poner_En_Intermitente()
        {
            intermitente = true;
        }
        public void quitar_Intermitente()
        {
            intermitente = false;
            color_actual = "Rojo";
            tiempo_actual = 0;
        }
    }
}
