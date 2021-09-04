using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADVentaDetalle
    {
        private static VentaDetalleTableAdapter adaptador = new VentaDetalleTableAdapter();

        public static void VentaDetalleInsertVentaDetalle(
            int IDVenta,
            string Codigo,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.VentaDetalleInsert(IDVenta, Codigo, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static DSMiAppComercial.VentaDetalleDataTable VentaDetalleGetVentaDetalleByIDVenta(int IDVenta)
        {
            return adaptador.VentaDetalleGetVentaDetalleByIDVenta(IDVenta);
        }
    }
}