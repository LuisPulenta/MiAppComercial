using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADCompra
    {
        private static CompraTableAdapter adaptador = new CompraTableAdapter();

        public static int CompraInsert(
            DateTime Fecha,
            int IDProveedor,
            int IDAlmacen)
        {
            return (int)adaptador.CompraInsert(Fecha, IDProveedor, IDAlmacen);
        }
    }
}