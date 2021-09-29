using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADSalida
    {
        public int IDSalida { get; set; }
        public DateTime Fecha { get; set; }
        public int IDConcepto { get; set; }
        public int IDAlmacen { get; set; }

        private static SalidaTableAdapter adaptador = new SalidaTableAdapter();

        public static int SalidaInsertSalida(
            DateTime Fecha,
            int IDConcepto,
            int IDAlmacen)
        {
            return (int)adaptador.SalidaInsert(Fecha, IDConcepto, IDAlmacen);
        }

        public static CADSalida SalidasGetSalidaByIDSalida(int IDSalida)
        {
            CADSalida miSalida = null;
            DSMiAppComercial.SalidaDataTable miTabla = adaptador.SalidasGetSalidaByIDSalida(IDSalida);
            if (miTabla.Rows.Count == 0)
            {
                return miSalida;
            }
            else
            {
                DSMiAppComercial.SalidaRow miRegistro = (DSMiAppComercial.SalidaRow)miTabla.Rows[0];
                miSalida = new CADSalida();
                miSalida.Fecha = miRegistro.Fecha;
                miSalida.IDConcepto = miRegistro.IDConcepto;
                miSalida.IDAlmacen = miRegistro.IDAlmacen;
                miSalida.IDSalida = miRegistro.IDSalida;
                return miSalida;
            }
        }
    }
}