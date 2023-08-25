namespace APIColegio.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
        public string CourseCode { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Estado {get; set;}
        public int CantidadEgresados { get; set; }
        public string? MedioEntrega { get; set; }
        public string? Vendedor { get; set; }
        public string? ColegioNivel { get; set; }
        public string? ColegioNombre { get; set; }
        public string? ColegioCurso { get; set; }
        public string? ColegioLocalidad { get; set; }
        public string? Comision { get; set; }
        public double Total { get; set; }
    }
}
