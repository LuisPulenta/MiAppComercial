using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADTraslado
    {
        private static TrasladoTableAdapter adaptador = new TrasladoTableAdapter();

        public static int TrasladoInsertTraslado(
            DateTime Fecha,
            int IDAlmacenOrigen,
            int IDAlmacenDestino)
        {
            return (int)adaptador.TrasladoInsert(Fecha, IDAlmacenOrigen, IDAlmacenDestino);
        }
    }
}