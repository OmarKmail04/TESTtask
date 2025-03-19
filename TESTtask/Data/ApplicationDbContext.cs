using Microsoft.EntityFrameworkCore;
using TESTtask.Models;

namespace TESTtask.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Aweird;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity => {
                entity.Property(p => p.Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(100);
            
            
            
            
            
            });
        }
        public DbSet<Categories> Catches { get; set; }
    }
}
