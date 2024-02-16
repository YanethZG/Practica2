using System.ComponentModel.DataAnnotations;

namespace Practica2.Models
{
    public class MCategorias
    {
        [Key]
        public int idCategoria { get; set; }
        [Required]
        [Display(Name = "Categorias")]

        public string nombre { get; set; }
        [Required]
        public string ordenes { get; set; }
    }
}
