using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Bicicleta : IVehiculos
    {
        public const int limite = 10;
        public int pos_act = 0;

        public int mover(int tiempo)
        {
            pos_act += tiempo * limite;
            return tiempo * limite;
        }

        public int posicion()
        {
            return pos_act;
        }

        public void reiniciarPosicion()
        {
            pos_act = 0;
        }
    }
}
