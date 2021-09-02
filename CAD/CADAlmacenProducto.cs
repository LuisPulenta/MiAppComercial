using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADAlmacenProducto
    {
        public int IDAlmacen { get; set; }
        public string Codigo { get; set; }
        public float Stock { get; set; }
        public float Minimo { get; set; }
        public float Maximo { get; set; }
        public int DiasReposicion { get; set; }
        public float CantidadMinima { get; set; }

        private static AlmacenProductoTableAdapter adaptador = new AlmacenProductoTableAdapter();

        public static CADAlmacenProducto AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(int IDAlmacen, string Codigo)
        {
            CADAlmacenProducto miAlmacenProducto = null;
            DSMiAppComercial.AlmacenProductoDataTable miTabla = adaptador.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(IDAlmacen, Codigo);
            if (miTabla.Rows.Count == 0)
            {
                return miAlmacenProducto;
            }
            else
            {
                DSMiAppComercial.AlmacenProductoRow miRegistro = (DSMiAppComercial.AlmacenProductoRow)miTabla.Rows[0];
                miAlmacenProducto = new CADAlmacenProducto();
                miAlmacenProducto.CantidadMinima = (float)miRegistro.CantidadMinima;
                miAlmacenProducto.DiasReposicion = miRegistro.DiasReposicion;
                miAlmacenProducto.IDAlmacen = miRegistro.IDAlmacen;
                miAlmacenProducto.Codigo = miRegistro.Codigo;
                miAlmacenProducto.Minimo = (float)miRegistro.Minimo;
                miAlmacenProducto.Maximo = (float)miRegistro.Maximo;
                miAlmacenProducto.Stock = (float)miRegistro.Stock;

                return miAlmacenProducto;
            }
        }

        public static void AlmacenProductoUpdate(
                   int IDAlmacen,
                   string Codigo,
                   float Minimo,
                   float Maximo,
                   int DiasReposicion,
                   float CantidadMinima)
        {
            try
            {
                adaptador.AlmacenProductoInsert(IDAlmacen, Codigo, 0, Minimo, Maximo, DiasReposicion, CantidadMinima);
            }
            catch (System.Exception)
            {
                adaptador.AlmacenProductoUpdate(Minimo, Maximo, DiasReposicion, CantidadMinima, IDAlmacen, Codigo);
            }
        }

        public static void AlmacenProductoActualizaStock(float Cantidad, int IDAlmacen, string Codigo)
        {
            adaptador.AlmacenProductoActualizaStock(Cantidad, IDAlmacen, Codigo);
        }

        public static DSMiAppComercial.AlmacenProductoDataTable GetData()
        {
            return adaptador.GetData();
        }
    }
}