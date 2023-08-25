namespace APIColegio.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int  ContratoId { get; set; }
        public virtual Item? Item { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
    }
}
