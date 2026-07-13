using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalonDeBelleza.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [StringLength(15)]
        public string? DUI { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Correo { get; set; }

        [StringLength(255)]
        public string? Direccion { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        // Relación: Un cliente puede tener muchas citas
        public virtual ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
