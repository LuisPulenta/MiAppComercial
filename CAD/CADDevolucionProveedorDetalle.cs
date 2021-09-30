using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionProveedorDetalle
    {
        private static DevolucionProveedorDetalleTableAdapter adaptador = new DevolucionProveedorDetalleTableAdapter();

        public static void DevolucionProveedorDetalleInsert(
            int IDDevolucionProveedor,
            string Codigo,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.DevolucionProveedorDetalleInsert(IDDevolucionProveedor, Codigo, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static double DevolucionProveedorGetHistoria(int IDCompra, string Codigo)
        {
            try
            {
                return (double)adaptador.DevolucionProveedorGetHistoria(IDCompra, Codigo);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DSMiAppComercial.DevolucionProveedorDetalleDataTable DevolucionProveedorDetalleGetDevolucionProveedorDetalleByIDDevolucionProveedor(int IDDevolucionProveedor)
        {
            return adaptador.DevolucionProveedorDetalleGetDevolucionProveedorDetalleByIDDevolucionProveedor(IDDevolucionProveedor);
        }
    }
}