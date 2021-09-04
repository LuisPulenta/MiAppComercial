namespace Win.Clases
{
    public class DevolucionClienteDisponible
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public float CantidadOriginal { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }
        public float CantidadDevuelta { get; set; }
        public float CantidadDisponible => CantidadOriginal - CantidadDevuelta;
    }
}