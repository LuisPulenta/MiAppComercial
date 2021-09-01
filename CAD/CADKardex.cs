using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADKardex
    {
        public int IDKardex { get; set; }
        public int IDAlmacen { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public float Entrada { get; set; }
        public float Salida { get; set; }
        public float Saldo { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal CostoPromedio { get; set; }

        private static KardexTableAdapter adaptador = new KardexTableAdapter();

        public static CADKardex KardexUltimoKardex(int IDAlmacen, string Codigo)
        {
            CADKardex miKardex = null;
            DSMiAppComercial.KardexDataTable miTabla = adaptador.KardexUltimo(IDAlmacen, Codigo);
            if (miTabla.Rows.Count == 0)
            {
                return miKardex;
            }
            else
            {
                DSMiAppComercial.KardexRow miRegistro = (DSMiAppComercial.KardexRow)miTabla.Rows[0];
                miKardex = new CADKardex();
                miKardex.IDKardex = miRegistro.IDKardex;
                miKardex.IDAlmacen = miRegistro.IDAlmacen;
                miKardex.Codigo = miRegistro.Codigo;
                miKardex.Fecha = miRegistro.Fecha;
                miKardex.Documento = miRegistro.Documento;
                miKardex.Entrada = (float)miRegistro.Entrada;
                miKardex.Salida = (float)miRegistro.Salida;
                miKardex.Saldo = (float)miRegistro.Saldo;
                miKardex.UltimoCosto = miRegistro.UltimoCosto;
                miKardex.CostoPromedio = miRegistro.CostoPromedio;
                return miKardex;
            }
        }

        public static int KardexInsert(
           int IDAlmacen,
           string Codigo,
           DateTime Fecha,
           string Documento,
           float Entrada,
           float Salida,
           float Saldo,
           decimal UltimoCosto,
           decimal CostoPromedio)
        {
            return (int)adaptador.KardexInsert(IDAlmacen, Codigo, Fecha, Documento, Entrada, Salida, Saldo, UltimoCosto, CostoPromedio);
        }
    }
}