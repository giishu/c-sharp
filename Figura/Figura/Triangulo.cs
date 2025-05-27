using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Triangulo : IFigura
    {
        public float basa;
        public float altura;
        public float lado2;
        public float lado3;

        public Triangulo(float b, float a, float l2, float l3)
        {
            basa = b;
            altura = a;
            lado2 = l2;
            lado3 = l3;
        }

        public float calcularArea()
        {
            return (basa * altura) / 2;
        }

        public float calcularPerimetro()
        {
            return basa + lado2 + lado3;
        }
    }
}
