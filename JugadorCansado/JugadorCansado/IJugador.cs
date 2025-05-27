using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorCansado
{
    internal interface IJugador
    {
        bool correr(int minutos);
        bool cansado();
        void descansar(int minutos);
    }
}
