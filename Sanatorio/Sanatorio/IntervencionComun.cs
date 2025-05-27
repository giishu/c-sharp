namespace Sanatorio
{
    public class IntervencionComun : Intervencion
    {
        public IntervencionComun(string codigo, string descripcion, string especialidad, decimal arancel)
            : base(codigo, descripcion, especialidad, arancel)
        {
        }

        public override decimal CalcularCostoTotal()
        {
            return Arancel;
        }
    }
}
