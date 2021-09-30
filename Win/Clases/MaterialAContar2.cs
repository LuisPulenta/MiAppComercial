namespace Win.Clases
{
    public class MaterialAContar2
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public int Medida { get; set; }
        public double Stock { get; set; }
        public double Conteo1 { get; set; }
        public double Conteo2 { get; set; }
        public double Conteo3 { get; set; }
        public double Ajuste { get; set; }
        public decimal? UltimoCosto { get; set; }
        public decimal? CostoPromedio { get; set; }
        public decimal valorSobranteUltimoCosto { get; set; }
        public decimal valorFaltanteUltimoCosto { get; set; }
        public decimal valorSobranteCostoPromedio { get; set; }
        public decimal valorFaltanteCostoPromedio { get; set; }
    }
}