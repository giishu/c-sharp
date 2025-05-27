using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Paciente
    {
        public string Dni;
        public string Nombre_ap;
        public string Telefono;
        public List<Intervencion> Intervenciones = new List<Intervencion>();

        public string ObraSocial;
        public double? MontoCobertura;

        public Paciente(string documentoIdentidad, string nombre, string telefono,
                  string obraSocial = null, double? montoCobertura = null)
        {
            Dni = documentoIdentidad;
            Nombre_ap = nombre;
            Telefono = telefono;
            ObraSocial = obraSocial;
            MontoCobertura = montoCobertura;
        }
        public override string ToString()
        {
            return $"{Nombre_ap} (DNI: {Dni}, Tel: {Telefono}) - " + $"{(ObraSocial != null ? $"OS: {ObraSocial} ({MontoCobertura})" : "Sin obra social")}";
        }


    }
}
