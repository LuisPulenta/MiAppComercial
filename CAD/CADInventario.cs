using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADInventario
    {
        private static InventarioTableAdapter adaptador = new InventarioTableAdapter();

        public static int InventarioInsert(
            DateTime Fecha,
            int IDAlmacen)
        {
            return (int)adaptador.InventarioInsert(Fecha, 1, IDAlmacen);
        }
    }
}