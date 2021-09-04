using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionClienteDetalle
    {
        private static DevolucionClienteDetalleTableAdapter adaptador = new DevolucionClienteDetalleTableAdapter();

        public static void DevolucionClienteDetalleInsert(
            int IDDevolucionCliente,
            string Codigo,
            string Descripcion,
            decimal Precio,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.DevolucionClienteDetalleInsert(IDDevolucionCliente, Codigo, Descripcion, Precio, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static double DevolucionClienteGetHistoria(int IDVenta, string Codigo)
        {
            try
            {
                return (double)adaptador.DevolucionClienteGetHistoria(IDVenta, Codigo);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
