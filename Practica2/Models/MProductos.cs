using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica2.Models
{
    public class MProductos
    {
        [Key]
        public int idProducto { get; set; }
        [Required]
        [Display (Name ="Nombre del producto")]
        public string nombre { get; set; }

        [Display (Name ="Descripcion corta")]
        public string descripcionCorta {  get; set; }
        [Display (Name ="Descripcion")]
        public string descripcion { get; set;}
        [Required]

        public double precio { get; set; }
        [Required]
        public string imagen {  get; set; }
        [Display (Name ="Consola")]
        public int idConsola { get; set; }
        [Display (Name ="Consola")]
        [ForeignKey ("idConsola")]
        public virtual MConsolas MConsolas { get; set; }
        [Display (Name ="Categoria")]
        public int idCategoria { get; set; }
        [Display (Name ="Categoria")]
        [ForeignKey ("idCategoria")]
        public virtual MCategorias MCategorias { get; set; }


       

    }
}
