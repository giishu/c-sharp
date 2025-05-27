using System;
using Sanatorio;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        Console.WriteLine("=== Sistema de Intervenciones del Sanatorio ===");

        // Registrar una intervención (paciente, intervención, doctor)
        // Usamos valores que ya están en el constructor de Hospital
        string dniPaciente = "30111222";             // Ana Torres
        string codigoIntervencion = "INT001";        // Bypass coronario
        string matriculaDoctor = "12345";            // Juan Pérez (Cardiología)

        DateTime fecha = DateTime.Today;

        hospital.RegistrarIntervencion(fecha, dniPaciente, codigoIntervencion, matriculaDoctor);

        Console.WriteLine();
        hospital.GenerarReporteDePendientes();

        Console.WriteLine("\nPresioná cualquier tecla para salir...");
        Console.ReadKey();
    }
}
