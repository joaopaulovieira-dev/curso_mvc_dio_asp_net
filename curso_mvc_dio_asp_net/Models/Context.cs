using Microsoft.EntityFrameworkCore;
using System;

namespace curso_mvc_dio_asp_net.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=curso_mvc_dio_asp_net;Integrated Security=True");
        }

        public void FindAsync(int v)
        {
            throw new NotImplementedException();
        }

        public void SetModifield(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}