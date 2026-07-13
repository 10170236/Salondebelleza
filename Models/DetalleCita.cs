using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class DetalleCita
    {
        [Key]
        public int IdDetalleCita { get; set; }

        [Required]
        public int CitaId { get; set; }
        [ForeignKey("CitaId")]
        public virtual Cita Cita { get; set; } = null!;

        [Required]
        public int ServicioId { get; set; }
        [ForeignKey("ServicioId")]
        public virtual Servicio Servicio { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; } // Histórico del precio al momento de la cita
    }
}
