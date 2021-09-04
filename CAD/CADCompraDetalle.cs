using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADCompraDetalle
    {
        private static CompraDetalleTableAdapter adaptador = new CompraDetalleTableAdapter();

        public static void CompraDetalleInsertCompraDetalle(
            int IDCompra,
            string Codigo,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.CompraDetalleInsert(IDCompra, Codigo, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static DSMiAppComercial.CompraDetalleDataTable CompraDetalleGetCompraDetalleByIDCompra(int IDCompra)
        {
            return adaptador.CompraDetalleGetCompraDetalleByIDCompra(IDCompra);
        }
    }
}