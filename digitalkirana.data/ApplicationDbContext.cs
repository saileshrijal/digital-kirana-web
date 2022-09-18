using digitalkirana.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace digitalkirana.web.data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ApplicationUser>? ApplicationUsers { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Purchase>? Purchases { get; set; }
    public DbSet<PurchaseDetails>? PurchaseDetails { get; set; }
    public DbSet<Sales>? Sales { get; set; }
    public DbSet<SalesDetails>? SalesDetails { get; set; }
    public DbSet<Supplier>? Suppliers { get; set; }
}
