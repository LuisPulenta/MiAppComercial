using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADProducto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int IDCategoria { get; set; }
        public int IDIVA { get; set; }
        public decimal Precio { get; set; }
        public string Notas { get; set; }
        public string Imagen { get; set; }
        public string IDUnidad { get; set; }
        public float Medida { get; set; }

        private static readonly ProductoTableAdapter adaptador = new ProductoTableAdapter();

        public static CADProducto ProductoGetProductoByCodigo(string Codigo)
        {
            CADProducto miProducto = null;
            DSMiAppComercial.ProductoDataTable miTabla = adaptador.ProductoGetProductoByCodigo(Codigo);
            if (miTabla.Rows.Count == 0)
            {
                return miProducto;
            }
            else
            {
                DSMiAppComercial.ProductoRow miRegistro = (DSMiAppComercial.ProductoRow)miTabla.Rows[0];
                miProducto = new CADProducto
                {
                    Descripcion = miRegistro.Descripcion,
                    IDCategoria = miRegistro.IDCategoria,
                    IDIVA = miRegistro.IDIVA,
                    IDUnidad = miRegistro.IDUnidad,
                    Codigo = miRegistro.Codigo,
                    Imagen = miRegistro.Imagen,
                    Medida = (float)miRegistro.Medida,
                    Notas = miRegistro.Notas,
                    Precio = miRegistro.Precio
                };
                return miProducto;
            }
        }

        public static CADProducto ProductoGetProductoByIDBarra(long IDBarra)
        {
            CADProducto miProducto = null;
            DSMiAppComercial.ProductoDataTable miTabla = adaptador.ProductoGetProductoByIDBarra(IDBarra);
            if (miTabla.Rows.Count == 0)
            {
                return miProducto;
            }
            else
            {
                DSMiAppComercial.ProductoRow miRegistro = (DSMiAppComercial.ProductoRow)miTabla.Rows[0];
                miProducto = new CADProducto
                {
                    Descripcion = miRegistro.Descripcion,
                    IDCategoria = miRegistro.IDCategoria,
                    IDIVA = miRegistro.IDIVA,
                    IDUnidad = miRegistro.IDUnidad,
                    Codigo = miRegistro.Codigo,
                    Imagen = miRegistro.Imagen,
                    Medida = (float)miRegistro.Medida,
                    Notas = miRegistro.Notas,
                    Precio = miRegistro.Precio
                };
                return miProducto;
            }
        }

    }
}