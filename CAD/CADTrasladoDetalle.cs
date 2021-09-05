using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADTrasladoDetalle
    {
        private static TrasladoDetalleTableAdapter adaptador = new TrasladoDetalleTableAdapter();

        public static void TrasladoDetalleInsert(
            int IDTraslado,
            string Codigo,
            string Descripcion,
            float Cantidad,
            int IDKardexOrigen,
            int IDKardexDestino)
        {
            adaptador.TrasladoDetalleInsert(IDTraslado, Codigo, Descripcion, Cantidad, IDKardexOrigen, IDKardexDestino);
        }
    }
}