using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorCansado
{
    internal class Profesional : IJugador
    {
        public int minutos_corridos = 0;
        public const int limite = 40;

        public bool correr(int minutos)
        {
            if (minutos_corridos + minutos > limite)
                return false;
            else
            {
                minutos_corridos += minutos;
                return true;
            }
        }
        public bool cansado()
        {
            return minutos_corridos >= limite;
        }
        public void descansar(int minutos)
        {
            if (minutos_corridos - minutos < 0)
                minutos_corridos = 0;
            else
                minutos_corridos -= minutos;
        }
    }
}
