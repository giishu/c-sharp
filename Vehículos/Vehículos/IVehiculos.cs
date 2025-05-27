using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal interface IVehiculos
    {
        int mover(int tiempo);
        int posicion();
        void reiniciarPosicion();
    }
}
