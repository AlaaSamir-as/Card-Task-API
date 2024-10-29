using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace InfraStructureLayer.DBContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {
           
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CartItem> CartItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne<Category>(s => s.Category)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CategoryId);
        }
    }
}
