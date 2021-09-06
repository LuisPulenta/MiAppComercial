using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADInventarioDetalle
    {
        private static InventarioDetalleTableAdapter adaptador = new InventarioDetalleTableAdapter();

        public static void InventarioDetalleInsert(
            int IDInventario,
            string Codigo,
            string Descripcion,
            double Stock,
            double Conteo1,
            double Conteo2,
            double Conteo3,
            double Ajuste)
        {
            adaptador.InventarioDetalleInsert(IDInventario, Codigo, Descripcion, Stock, Conteo1, Conteo2, Conteo3, Ajuste);
        }
    }
}