using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADSalidaDetalle2
    {
        private static SalidaDetalle2TableAdapter adaptador = new SalidaDetalle2TableAdapter();

        public static DSMiAppComercial.SalidaDetalle2DataTable SalidaDetalleGetSalidaDetalleByIDSalida(int IDSalida)
        {
            return adaptador.SalidaDetalleGetSalidaDetalleByIDSalida(IDSalida);
        }
    }
}
