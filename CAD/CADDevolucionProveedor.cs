using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionProveedor
    {
        public int IDDevolucionProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int IDProveedor { get; set; }
        public int IDCompra { get; set; }

        private static DevolucionProveedorTableAdapter adaptador = new DevolucionProveedorTableAdapter();

        public static int DevolucionProveedorInsert(
            DateTime Fecha,
            int IDCompra)
        {
            return (int)adaptador.DevolucionProveedorInsert(Fecha, IDCompra);
        }

        public static CADDevolucionProveedor DevolucionProveedorGetDevolucionProveedorByIDDevolucionProveedor(int IDDevolucionProveedor)
        {
            CADDevolucionProveedor miDevolucionProveedor = null;
            DSMiAppComercial.DevolucionProveedorDataTable miTabla = adaptador.DevolucionProveedorGetDevolucionProveedorByIDDevolucionProveedor(IDDevolucionProveedor);
            if (miTabla.Rows.Count == 0)
            {
                return miDevolucionProveedor;
            }
            else
            {
                DSMiAppComercial.DevolucionProveedorRow miRegistro = (DSMiAppComercial.DevolucionProveedorRow)miTabla.Rows[0];
                miDevolucionProveedor = new CADDevolucionProveedor();
                miDevolucionProveedor.Fecha = miRegistro.Fecha;
                miDevolucionProveedor.IDDevolucionProveedor = (int) miRegistro.IDDevolucionProveedor;
                miDevolucionProveedor.IDCompra = miRegistro.IDCompra;
                return miDevolucionProveedor;
            }
        }
    }
}