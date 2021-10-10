using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADCompra
    {
        public int IDCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IDProveedor { get; set; }
        public int IDAlmacen { get; set; }

        private static CompraTableAdapter adaptador = new CompraTableAdapter();

        public static int CompraInsert(
            DateTime Fecha,
            int IDProveedor,
            int IDAlmacen)
        {
            return (int)adaptador.CompraInsert(Fecha, IDProveedor, IDAlmacen);
        }

        public static CADCompra ComprasGetCompraByIDCompra(int IDCompra)
        {
            CADCompra miCompra = null;
            DSMiAppComercial.CompraDataTable miTabla = adaptador.ComprasGetCompraByIDCompra(IDCompra);
            if (miTabla.Rows.Count == 0)
            {
                return miCompra;
            }
            else
            {
                DSMiAppComercial.CompraRow miRegistro = (DSMiAppComercial.CompraRow)miTabla.Rows[0];
                miCompra = new CADCompra();
                miCompra.Fecha = miRegistro.Fecha;
                miCompra.IDProveedor = miRegistro.IDProveedor;
                miCompra.IDAlmacen = miRegistro.IDAlmacen;
                miCompra.IDCompra = miRegistro.IDCompra;
                return miCompra;
            }
        }

        public static void CompraUpdateFecha(DateTime fecha,int IDCompra)
        {
            adaptador.CompraUpdateFecha(fecha,IDCompra);
        }
    }
}