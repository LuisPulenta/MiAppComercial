using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADInventario
    {
        private static InventarioTableAdapter adaptador = new InventarioTableAdapter();

        public static int InventarioInsert(
            DateTime Fecha,
            int IDAlmacen,
            string Categoría)
        {
            return (int)adaptador.InventarioInsert(Fecha, 1, IDAlmacen,Categoría);
        }

        public static void InventarioUpDatePaso(int Paso, int IDInventario)
        {
            adaptador.InventarioUpdatePaso(Paso, IDInventario);
        }
    }
}