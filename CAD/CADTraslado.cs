using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADTraslado
    {
        public int IDTraslado { get; set; }
        public DateTime Fecha { get; set; }
        public int IDAlmacenOrigen { get; set; }
        public int IDAlmacenDestino { get; set; }

        private static TrasladoTableAdapter adaptador = new TrasladoTableAdapter();

        public static int TrasladoInsertTraslado(
            DateTime Fecha,
            int IDAlmacenOrigen,
            int IDAlmacenDestino)
        {
            return (int)adaptador.TrasladoInsert(Fecha, IDAlmacenOrigen, IDAlmacenDestino);
        }

        public static CADTraslado TrasladosGetTrasladoByIDTraslado(int IDTraslado)
        {
            CADTraslado miTraslado= null;
            DSMiAppComercial.TrasladoDataTable miTabla = adaptador.TrasladosGetTrasladoByIDTraslado(IDTraslado);
            if (miTabla.Rows.Count == 0)
            {
                return miTraslado;
            }
            else
            {
                DSMiAppComercial.TrasladoRow miRegistro = (DSMiAppComercial.TrasladoRow)miTabla.Rows[0];
                miTraslado = new CADTraslado();
                miTraslado.Fecha = miRegistro.Fecha;
                miTraslado.IDAlmacenOrigen = miRegistro.IDAlmacenOrigen;
                miTraslado.IDAlmacenDestino = miRegistro.IDAlmacenDestino;
                miTraslado.IDTraslado = miRegistro.IDTraslado;
                return miTraslado;
            }
        }
    }
}