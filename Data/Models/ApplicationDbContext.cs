using Microsoft.EntityFrameworkCore;
using PNCDemoWebApi.Data.Models;

namespace PNCDemoWebApi.Data.Models
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
         : base(options)
        {
        }
        #endregion Constructor
        #region Properties
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        #endregion Properties

        #region Methods
        protected override void OnModelCreating(ModelBuilder
         modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map Entity names to DB Table names
            modelBuilder.Entity<Supplier>().ToTable("Suppliers");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Rating>().ToTable("Ratings");

            //Fluent API method chained calls
            modelBuilder.Entity<Supplier>()
                    .Property(s => s.City)
                    .HasColumnName("Location")
                    .HasDefaultValue("London")
                    .IsRequired();

        }
        #endregion Methods

       
    }
}
