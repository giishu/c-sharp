using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Circulo : IFigura
    {
        public static readonly float pi = 3.14159f;
        public float radio;

        public Circulo(float r)
        {
            radio = r;
        }

        public float calcularArea()
        {
            return pi * radio * radio;
        }

        public float calcularPerimetro()
        {
            return 2 * pi * radio;
        }
    }
}
