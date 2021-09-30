using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADTrasladoDetalle2
    {
        private static TrasladoDetalle2TableAdapter adaptador = new TrasladoDetalle2TableAdapter();

        public static DSMiAppComercial.TrasladoDetalle2DataTable TrasladoDetalleGetTrasladoDetalleByIDTraslado(int IDTraslado)
        {
            return adaptador.TrasladoDetalleGetTrasladoDetalleByIDTrasladoDetalle(IDTraslado);
        }
    }
}
