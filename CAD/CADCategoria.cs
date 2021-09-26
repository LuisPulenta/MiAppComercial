using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADCategoria
    {
        private static readonly CategoriaTableAdapter adaptador = new CategoriaTableAdapter();

        public static string CategoriaDescripcion(int IDCategoria)
        {
            if (adaptador.CategoriaDescripcion(IDCategoria) == null)
            {
                return "";
            }
            else
            {
                return adaptador.CategoriaDescripcion(IDCategoria).ToString();
            }
        }

    }
}