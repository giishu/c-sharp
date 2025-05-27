using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Auto : IVehiculos
    {
        public int pos_act = 0;
        public int limite;

        public Auto()
        {
            limite = 40;
        }
        public Auto(int v_max)
        {
            limite = v_max;
        }

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
