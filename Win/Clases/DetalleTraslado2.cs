namespace Win.Clases
{
    public class DetalleTraslado2
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal CostoPromedio { get; set; }
        public float Cantidad { get; set; }

        public decimal valorUltimoCosto { get { return (decimal)Cantidad * UltimoCosto; } }
        public decimal valorCostoPromedio { get { return (decimal)Cantidad * CostoPromedio; } }
    }
}