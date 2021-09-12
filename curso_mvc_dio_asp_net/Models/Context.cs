using Microsoft.EntityFrameworkCore;

namespace curso_mvc_dio_asp_net.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=curso_mvc_dio_asp_net;Integrated Security=True");
        }
    }
}