using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [Required]
        public int Duracion { get; set; } // En minutos

        [StringLength(500)]
        public string? Descripcion { get; set; }

        // Relación: Un servicio puede estar en muchos detalles de cita
        public virtual ICollection<DetalleCita> DetallesCitas { get; set; } = new List<DetalleCita>();
    }
}
