using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Rol { get; set; } = "Recepcionista"; // Administrador, Recepcionista

        // Relación opcional con Empleado
        public int? EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual Empleado? Empleado { get; set; }
    }
}
