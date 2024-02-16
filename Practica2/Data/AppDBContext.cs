using Microsoft.EntityFrameworkCore;
using Practica2.Models;

namespace Practica2.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options)
        {

        }
        public DbSet<MCategorias> tbl_categoria {  get; set; }
        public DbSet<MConsolas> tbl_consola { get; set; }
        public DbSet<MProductos> tbl_producto { get; set; }
    }
}
