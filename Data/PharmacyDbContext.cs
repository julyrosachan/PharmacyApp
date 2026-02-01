using Microsoft.EntityFrameworkCore;
using PharmacyApp.Entities;

namespace PharmacyApp.Data;

public class PharmacyDbContext : DbContext
{
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=localhost,1433;Database=PharmacyDb;User Id=sa;Password=YasuIsTheBest_707!;TrustServerCertificate=True"
        );
    }
}
