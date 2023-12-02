using Microsoft.EntityFrameworkCore;
namespace ApplicationTp2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //si je vais faire la relation entre movie et genre
        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
                  modelBuilder.Entity<Genre>()
                 .HasMany(g => g.Movie)
                 .WithOne(m => m.Genre)
                 .HasForeignKey(m => m.genre_Id)
                 .IsRequired(false);

         }*/


    }
}

