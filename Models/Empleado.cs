using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalonDeBelleza.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Especialidad { get; set; } = string.Empty; // Estilista, Manicurista, Colorista, Maquillista, Recepcionista

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Correo { get; set; }

        [StringLength(100)]
        public string? Horario { get; set; }

        // Relación: Un empleado puede atender muchas citas
        public virtual ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
