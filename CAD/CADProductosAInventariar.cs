using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADProductosAInventariar
    {
        private static ProductosAInventariarTableAdapter adaptador = new ProductosAInventariarTableAdapter();

        public static DSMiAppComercial.ProductosAInventariarDataTable ProductosAInventariarByIDBodega(int IDAlmacen)
        {
            return adaptador.ProductosAInventariarByIDAlmacen(IDAlmacen);
        }

        public static DSMiAppComercial.ProductosAInventariarDataTable ProductosAInventariarByIDBodegaAndIDDepartamento(int IDAlmacen, int IDCategoria)
        {
            return adaptador.ProductosAInventariarByIDAlmacenAndIDCategoria(IDAlmacen, IDCategoria);
        }
    }
}