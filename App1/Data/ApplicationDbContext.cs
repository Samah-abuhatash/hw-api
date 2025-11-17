using App1.Models;
using Microsoft.EntityFrameworkCore;

namespace App1.Data
{
    public class ApplicationDbContext: DbContext
    {public DbSet<Product> proudcts { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=api12;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
