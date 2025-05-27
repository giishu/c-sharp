using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo
{
    internal class Semaforo
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

