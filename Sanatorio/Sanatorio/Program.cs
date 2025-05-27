using System;
using Sanatorio;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ SANATORIO ===");
            Console.WriteLine("1. Dar de alta nuevo paciente");
            Console.WriteLine("2. Listar pacientes");
            Console.WriteLine("3. Asignar intervención a paciente");
            Console.WriteLine("4. Calcular costo de intervenciones de un paciente");
            Console.WriteLine("5. Reporte de intervenciones pendientes");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Write("DNI: ");
                    string dni = Console.ReadLine();
                    Console.Write("Nombre completo: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("¿Tiene obra social? (s/n): ");
                    string tieneOS = Console.ReadLine().ToLower();
                    string obraSocial = null;
                    double? cobertura = null;
                    if (tieneOS == "s")
                    {
                        Console.Write("Nombre de la obra social: ");
                        obraSocial = Console.ReadLine();
                        Console.Write("Cobertura (%): ");
                        cobertura = double.Parse(Console.ReadLine());
                    }

                    hospital.DarDeAltaPaciente(dni, nombre, telefono, obraSocial, cobertura);
                    break;

                case 2:
                    hospital.ListarPacientes();
                    break;

                case 3:
                    Console.Write("DNI del paciente: ");
                    string dniPac = Console.ReadLine();
                    Console.Write("Código de intervención: ");
                    string codInt = Console.ReadLine();
                    Console.Write("Matrícula del doctor: ");
                    string matDoc = Console.ReadLine();
                    hospital.RegistrarIntervencion(DateTime.Today, dniPac, codInt, matDoc);
                    break;

                case 4:
                    Console.Write("DNI del paciente: ");
                    string dniCosto = Console.ReadLine();
                    hospital.CalcularCostoIntervencionesPorDNI(dniCosto);
                    break;

                case 5:
                    hospital.GenerarReporteDePendientes();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}
