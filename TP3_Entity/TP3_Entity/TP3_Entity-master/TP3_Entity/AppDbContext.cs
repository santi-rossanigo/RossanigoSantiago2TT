using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP3_Entity
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos => Set<Producto>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlConfig.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos"); 
            modelBuilder.Entity<Producto>()
                        .Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Producto>()
                        .Property(p => p.Precio).HasColumnType("decimal(18,2)");
        }
    }
}
