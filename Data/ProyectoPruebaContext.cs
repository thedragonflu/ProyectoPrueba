using ProyectoPrueba.Models;
using Microsoft.EntityFrameworkCore;
using ProyectoPrueba.Data.Configurations;
namespace ProyectoPrueba.Data
{
    public class ProyectoPruebaContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=ProyectoPrueba.db");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}