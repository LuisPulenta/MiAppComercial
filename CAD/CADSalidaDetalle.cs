using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADSalidaDetalle
    {
        private static SalidaDetalleTableAdapter adaptador = new SalidaDetalleTableAdapter();

        public static void SalidaDetalleInsertSalidaDetalle(
            int IDSalida,
            string Codigo,
            string Descripcion,
            float Cantidad,
            int IDKardex)
        {
            adaptador.SalidaDetalleInsert(IDSalida, Codigo, Descripcion, Cantidad, IDKardex);
        }
    }
}