using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionProveedor
    {
        private static DevolucionProveedorTableAdapter adaptador = new DevolucionProveedorTableAdapter();

        public static int DevolucionProveedorInsert(
            DateTime Fecha,
            int IDCompra)
        {
            return (int)adaptador.DevolucionProveedorInsert(Fecha, IDCompra);
        }
    }
}