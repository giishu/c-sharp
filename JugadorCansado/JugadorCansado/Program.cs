using System;

namespace JugadorCansado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IJugador jugador1 = new Profesional();
            IJugador jugador2 = new Amateur();

            Console.WriteLine("--- Profesional ---");
            Console.WriteLine($"Corrió 30 mins: {jugador1.correr(30)}"); // True
            Console.WriteLine($"¿Cansado?: {jugador1.cansado()}");      // False (30 < 40)
            Console.WriteLine($"Corrió 20 mins: {jugador1.correr(20)}"); // False (30 + 20 > 40)
            jugador1.descansar(10);
            Console.WriteLine($"Minutos tras descanso: {((Profesional)jugador1).minutos_corridos}"); // 20

            Console.WriteLine("\n--- Amateur ---");
            Console.WriteLine($"Corrió 15 mins: {jugador2.correr(15)}");    // True
            Console.WriteLine($"¿Cansado?: {jugador2.cansado()}");          // False (15 < 20)
            Console.WriteLine($"Corrió 10 mins: {jugador2.correr(10)}");    // False (15 + 10 > 20)
            jugador2.descansar(5);
            Console.WriteLine($"Minutos tras descanso: {((Amateur)jugador2).minutos_corridos}"); // 10
        }
    }
}
