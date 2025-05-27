using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronómetro
{
    public class Cronometro
    {
        private int segundos = 0;
        private int minutos = 0;

        public void IncrementarTiempo()
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
        }

        public void ReiniciarTiempo()
        {
            segundos = 0;
            minutos = 0;
        }

        public string MostrarTiempo()
        {
            return $"{minutos} minutos, {segundos} segundos";
        }
    }
}

