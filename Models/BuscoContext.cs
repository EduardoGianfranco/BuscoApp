using Microsoft.EntityFrameworkCore;

namespace BuscoApp.Models
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public BuscoContext(DbContextOptions dco) : base(dco){
        }
    }
}