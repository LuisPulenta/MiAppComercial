using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADVenta
    {
        public int IDVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int IDCliente { get; set; }
        public int IDAlmacen { get; set; }

        private static VentaTableAdapter adaptador = new VentaTableAdapter();

        public static int VentaInsert(
            DateTime Fecha,
            int IDCliente,
            int IDAlmacen)
        {
            return (int)adaptador.VentaInsert(Fecha, IDCliente, IDAlmacen);
        }

        public static CADVenta VentasGetVentaByIDVenta(int IDVenta)
        {
            CADVenta miVenta = null;
            DSMiAppComercial.VentaDataTable miTabla = adaptador.VentasGetVentaByIDVenta(IDVenta);
            if (miTabla.Rows.Count == 0)
            {
                return miVenta;
            }
            else
            {
                DSMiAppComercial.VentaRow miRegistro = (DSMiAppComercial.VentaRow)miTabla.Rows[0];
                miVenta = new CADVenta();
                miVenta.Fecha = miRegistro.Fecha;
                miVenta.IDCliente = miRegistro.IDCliente;
                miVenta.IDAlmacen = miRegistro.IDAlmacen;
                miVenta.IDVenta = miRegistro.IDVenta;
                return miVenta;
            }
        }

        //public static bool ProveedorTieneCompras(int IDProveedor)
        //{
        //    if (adaptador.ProveedorTieneCompras(IDProveedor) == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}