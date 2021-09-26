using CAD.DSMiAppComercialTableAdapters;

namespace CAD
{
    public class CADMaterialAContar
    {
       

        private static readonly MaterialAContarTableAdapter adaptador = new MaterialAContarTableAdapter();

        public static DSMiAppComercial.MaterialAContarDataTable GetData(int IDInventario)
        {
            return adaptador.GetData(IDInventario);
        }
    }
}