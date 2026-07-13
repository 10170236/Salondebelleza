using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        [Required]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; } = null!;

        [Required]
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual Empleado Empleado { get; set; } = null!;

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public TimeSpan Hora { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Confirmada, En proceso, Finalizada, Cancelada

        // Relación: Una cita puede tener muchos servicios detallados
        public virtual ICollection<DetalleCita> DetallesCitas { get; set; } = new List<DetalleCita>();

        // Relación: Una cita genera un pago (o muchos pagos, aquí simplificado a uno o cero hasta que se pague)
        public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
