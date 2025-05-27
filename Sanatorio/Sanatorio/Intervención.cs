using System;

namespace Sanatorio
{
    public abstract class Intervencion
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Especialidad { get; set; }
        public decimal Arancel { get; set; }

        public Intervencion(string codigo, string descripcion, string especialidad, decimal arancel)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Especialidad = especialidad;
            Arancel = arancel;
        }

        public abstract decimal CalcularCostoTotal();

        public override string ToString()
        {
            return $"{Codigo} - {Descripcion} ({Especialidad})";
        }
    }
}
