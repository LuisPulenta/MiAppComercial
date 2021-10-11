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

        public static void ReKardex()
        {
            DSMiAppComercial.AlmacenProductoDataTable misAlmacenProductos = CADAlmacenProducto.GetData();
            foreach (DSMiAppComercial.AlmacenProductoRow miAlmacenProducto in misAlmacenProductos.Rows)
            {
                DSMiAppComercial.KardexDataTable misKardex = adaptador.KardexGetKardexByIDAlmacenAndCodigo(miAlmacenProducto.IDAlmacen, miAlmacenProducto.Codigo);
                if (misKardex.Rows.Count > 0)
                {
                    float saldo = 0;
                    decimal costoPromedio = 0;
                    decimal ultimoCosto = 0;
                    if (misKardex[0].Entrada > 0)
                    {
                        saldo = (float)misKardex[0].Entrada;
                        costoPromedio = misKardex[0].UltimoCosto;
                        ultimoCosto = misKardex[0].UltimoCosto;
                    }
                    else
                    {
                        saldo = -(float)misKardex[0].Salida;
                        ultimoCosto = 0;
                    }
                    adaptador.KardexUpdate(saldo, costoPromedio, ultimoCosto, misKardex[0].IDKardex);
                    for (int i = 1; i < misKardex.Rows.Count; i++)
                    {
                        if (misKardex[i].Entrada > 0)
                        {
                            costoPromedio = (decimal)(saldo + misKardex[i].Entrada)==0 ? misKardex[i].UltimoCosto : ((decimal)saldo * costoPromedio + (decimal)misKardex[i].Entrada * misKardex[i].UltimoCosto) / (decimal)(saldo + misKardex[i].Entrada);
                            ultimoCosto = misKardex[i].UltimoCosto;
                            saldo += (float)misKardex[i].Entrada;
                        }
                        else
                        {
                            saldo -= (float)misKardex[i].Salida;
                        }
                        adaptador.KardexUpdate(saldo, costoPromedio, ultimoCosto, misKardex[i].IDKardex);
                    }
                }
            }
        }

        public static void CompraUpdateFecha(DateTime fecha, string IDCompra)
        {
            adaptador.KardexCompraUpdateFecha(fecha, IDCompra);
        }

        public static bool KardexCodigoTieneMovimientos(string Codigo)
        {
            if (adaptador.KardexCodigoTieneMovimientos(Codigo) == null)
            {
                return false;
            }
            return true;
        }

        public static bool KardexIDAlmacenTieneMovimientos(int IDAlmacen)
        {
            if (adaptador.KardexIDAlmacenTieneMovimientos(IDAlmacen) == null)
            {
                return false;
            }
            return true;
        }
    }
}