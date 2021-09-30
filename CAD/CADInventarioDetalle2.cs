using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADInventarioDetalle2
    {
        private static InventarioDetalle2TableAdapter adaptador = new InventarioDetalle2TableAdapter();

        public static DSMiAppComercial.InventarioDetalle2DataTable InventarioDetalleGetInventarioDetalleByIDInventario(int IDInventario)
        {
            return adaptador.InventarioDetalleGetInventarioDetalleByIDInventario(IDInventario);
            var a = 1;
        }
    }
}