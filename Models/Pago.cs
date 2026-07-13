using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        [Required]
        public int CitaId { get; set; }
        [ForeignKey("CitaId")]
        public virtual Cita Cita { get; set; } = null!;

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(50)]
        public string MetodoPago { get; set; } = string.Empty; // Efectivo, Tarjeta, Transferencia, Pago móvil
    }
}
