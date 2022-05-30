namespace Challenge.Models
{
    public class VentaModel
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Fecha { get; set; }
        public int VendedorId { get; set; }
    }
}
