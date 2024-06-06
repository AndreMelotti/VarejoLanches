using Microsoft.EntityFrameworkCore;
using VarejoLanches.Models;

namespace VarejoLanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanche { get; set; }

    }
}
