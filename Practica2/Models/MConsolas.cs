using System.ComponentModel.DataAnnotations;

namespace Practica2.Models
{
    public class MConsolas
    {
        [Key]
        public int idConsola { get; set; }

        [Required]
        [Display (Name ="Nombre de la consola")]

        public string nombre { get; set;}
        [Required]
        public string descripcion { get; set; }
    }
}
