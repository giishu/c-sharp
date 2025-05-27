namespace Sanatorio
{
    public class IntervencionAltaComplejidad : Intervencion
    {
        public static decimal PorcentajeAdicional { get; set; } = 0.25m;

        public IntervencionAltaComplejidad(string codigo, string descripcion, string especialidad, decimal arancel)
            : base(codigo, descripcion, especialidad, arancel)
        {
        }

        public override decimal CalcularCostoTotal()
        {
            return Arancel * (1 + PorcentajeAdicional);
        }

        public override string ToString()
        {
            return base.ToString() + " [Alta Complejidad]";
        }
    }
}
