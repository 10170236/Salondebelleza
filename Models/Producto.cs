using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonDeBelleza.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Marca { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [Required]
        public int Stock { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        [StringLength(150)]
        public string? Proveedor { get; set; }
    }
}
