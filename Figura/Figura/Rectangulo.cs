using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Rectangulo : IFigura
    {
        public float baseRect;
        public float altura;

        public Rectangulo(float a, float b)
        {
            baseRect = a;
            altura = b;
        }

        public float calcularArea()
        {
            return baseRect * altura;
        }

        public float calcularPerimetro()
        {
            return (baseRect * 2) + (altura * 2);
        }
    }
}
