using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionCliente
    {
        private static readonly DevolucionClienteTableAdapter adaptador = new DevolucionClienteTableAdapter();

        public static int DevolucionClienteInsert(
            DateTime Fecha,
            int IDVenta)
        {
            return (int)adaptador.DevolucionClienteInsert(Fecha, IDVenta);
        }
    }
}