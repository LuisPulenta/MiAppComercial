using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADDevolucionCliente
    {
        public int IDDevolucionCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int IDCliente { get; set; }
        public int IDVenta { get; set; }

        private static readonly DevolucionClienteTableAdapter adaptador = new DevolucionClienteTableAdapter();

        public static int DevolucionClienteInsert(
            DateTime Fecha,
            int IDVenta)
        {
            return (int)adaptador.DevolucionClienteInsert(Fecha, IDVenta);
        }

        public static CADDevolucionCliente DevolucionClienteGetDevolucionClienteByIDDevolucionCliente(int IDDevolucionCliente)
        {
            CADDevolucionCliente miDevolucionCliente = null;
            DSMiAppComercial.DevolucionClienteDataTable miTabla = adaptador.DevolucionClienteGetDevolucionClienteByIDDevolucionCliente(IDDevolucionCliente);
            if (miTabla.Rows.Count == 0)
            {
                return miDevolucionCliente;
            }
            else
            {
                DSMiAppComercial.DevolucionClienteRow miRegistro = (DSMiAppComercial.DevolucionClienteRow)miTabla.Rows[0];
                miDevolucionCliente = new CADDevolucionCliente();
                miDevolucionCliente.Fecha = miRegistro.Fecha;
                miDevolucionCliente.IDDevolucionCliente = (int)miRegistro.IDDevolucionCliente;
                miDevolucionCliente.IDVenta = miRegistro.IDVenta;
                return miDevolucionCliente;
            }
        }
    }
}