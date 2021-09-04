using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADSalida
    {
        private static SalidaTableAdapter adaptador = new SalidaTableAdapter();

        public static int SalidaInsertSalida(
            DateTime Fecha,
            int IDConcepto,
            int IDAlmacen)
        {
            return (int)adaptador.SalidaInsert(Fecha, IDConcepto, IDAlmacen);
        }
    }
}