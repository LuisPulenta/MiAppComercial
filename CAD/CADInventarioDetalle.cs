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

        public static void InventarioDetalleUpDateConteo1(double Conteo1,int IDLinea)
        {
            adaptador.InventarioDetalleUpdateConteo1(Conteo1,IDLinea);
        }

        public static void InventarioDetalleUpDateConteo2(double Conteo2, int IDLinea)
        {
            adaptador.InventarioDetalleUpdateConteo2(Conteo2, IDLinea);
        }

        public static void InventarioDetalleUpDateConteo3(double Conteo3, int IDLinea)
        {
            adaptador.InventarioDetalleUpdateConteo3(Conteo3, IDLinea);
        }

        public static void InventarioDetalleDelete(int IDInventario)
        {
            adaptador.InventarioDetalleDelete(IDInventario);
        }
    }
}