using System;

namespace Sanatorio
{
    public class SolicitudIntervencion
    {
        private static int ProximoId = 1;

        public int Id { get; }
        public DateTime Fecha { get; }
        public Intervencion Intervencion { get; }
        public Doctor Medico { get; }
        public Paciente Paciente { get; }
        public bool Pagado { get; set; }

        public SolicitudIntervencion(DateTime fecha, Intervencion intervencion, Doctor medico, Paciente paciente)
        {
            if (medico.Especialidad != intervencion.Especialidad)
                throw new Exception("El médico no tiene la especialidad requerida para esta intervención.");

            Id = ProximoId++;
            Fecha = fecha;
            Intervencion = intervencion;
            Medico = medico;
            Paciente = paciente;
            Pagado = false;

            // Si querés, podés agregar la intervención a la lista del paciente
            paciente.Intervenciones.Add(intervencion);
        }

        public decimal CalcularMontoFinal()
        {
            decimal monto = Intervencion.CalcularCostoTotal();

            if (!string.IsNullOrEmpty(Paciente.ObraSocial) && Paciente.MontoCobertura.HasValue)
            {
                monto -= monto * ((decimal)Paciente.MontoCobertura.Value / 100);
            }

            return monto;
        }

        public override string ToString()
        {
            string obraSocial = string.IsNullOrEmpty(Paciente.ObraSocial) ? "-" : Paciente.ObraSocial;
            return $"ID: {Id} | Fecha: {Fecha:dd/MM/yyyy} | {Intervencion.Descripcion} | " +
                   $"Paciente: {Paciente.Nombre_ap} | Médico: {Medico.Nombre_ap} ({Medico.Matricula}) | " +
                   $"OS: {obraSocial} | Importe: ${CalcularMontoFinal():F2} | Estado: {(Pagado ? "Pagado" : "Pendiente")}";
        }
    }
}
