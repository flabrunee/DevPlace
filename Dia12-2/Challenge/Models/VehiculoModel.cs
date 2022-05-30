namespace Challenge.Models
{
    public class VehiculoModel
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Importe { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? Anio { get; set; }
        public int? kilometraje { get; set; }
    }
}
