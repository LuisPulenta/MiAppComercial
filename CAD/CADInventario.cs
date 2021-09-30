using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADInventario
    {
        public int IDInventario { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }
        public int IDAlmacen { get; set; }

        private static InventarioTableAdapter adaptador = new InventarioTableAdapter();

        public static int InventarioInsert(
            DateTime Fecha,
            int IDAlmacen,
            string Categoría)
        {
            return (int)adaptador.InventarioInsert(Fecha, 1, IDAlmacen,Categoría);
        }

        public static void InventarioUpDatePaso(int Paso, int IDInventario)
        {
            adaptador.InventarioUpdatePaso(Paso, IDInventario);
        }

        public static int InventarioGetIDAlmacenByIDInventario(int IDInventario)
        {
            return (int) adaptador.InventarioGetIDAlmacenByIDInventario(IDInventario);
        }

        public static void InventarioDelete(int IDInventario)
        {
            adaptador.InventarioDelete(IDInventario);
        }

        public static CADInventario InventariosGetInventarioByIDInventario(int IDInventario)
        {
            CADInventario miInventario = null;
            DSMiAppComercial.InventarioDataTable miTabla = adaptador.InventariosGetInventarioByIDInventario(IDInventario);
            if (miTabla.Rows.Count == 0)
            {
                return miInventario;
            }
            else
            {
                DSMiAppComercial.InventarioRow miRegistro = (DSMiAppComercial.InventarioRow)miTabla.Rows[0];
                miInventario = new CADInventario();
                miInventario.Fecha = miRegistro.Fecha;
                miInventario.Categoria = miRegistro.Categoría;
                miInventario.IDAlmacen = miRegistro.IDAlmacen;
                miInventario.IDInventario = miRegistro.IDInventario;
                return miInventario;
            }
        }
    }
}
