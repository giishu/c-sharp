using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Cuadrado : IFigura
    {
        public float lado;

        public Cuadrado(float l)
        {
            lado = l;
        }

        public float calcularArea()
        {
            return lado * lado;
        }

        public float calcularPerimetro()
        {
            return lado * 4;
        }
    }
}
