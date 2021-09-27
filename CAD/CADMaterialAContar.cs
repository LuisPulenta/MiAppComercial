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

        public static DSMiAppComercial.MaterialAContarDataTable GetData2(int IDInventario)
        {
            return adaptador.GetData2(IDInventario);
        }

        public static DSMiAppComercial.MaterialAContarDataTable GetData3(int IDInventario)
        {
            return adaptador.GetData3(IDInventario);
        }
    }
}