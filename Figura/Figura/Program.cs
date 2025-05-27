using System;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras = new IFigura[4];

            figuras[0] = new Rectangulo(9, 12);
            figuras[1] = new Cuadrado(9);
            figuras[2] = new Triangulo(19, 74, 20, 13);
            figuras[3] = new Circulo(9);

            for (int i = 0; i < figuras.Length; i++)
            {
                Console.WriteLine($"Figura {i + 1}:");
                Console.WriteLine($"Área: {figuras[i].calcularArea()}");
                Console.WriteLine($"Perímetro: {figuras[i].calcularPerimetro()}");
                Console.WriteLine();
            }
        }
    }
}
