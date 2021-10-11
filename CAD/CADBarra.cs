using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADBarra
    {
        private static readonly BarraTableAdapter adaptador = new BarraTableAdapter();

        public static bool ExisteBarra(long Barra)
        {
            if (adaptador.BarraExiste(Barra) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void BarraInsert(
            string Codigo,
            long Barra)
        {
            adaptador.BarraInsert(Codigo, Barra);
        }

        public static void BarraDelete(long Barra)
        {
            adaptador.BarraDelete(Barra);
        }

        public static void DeleteBarraByCodigo(string Codigo)
        {
            adaptador.DeleteBarraByCodigo(Codigo);
        }

    }
}