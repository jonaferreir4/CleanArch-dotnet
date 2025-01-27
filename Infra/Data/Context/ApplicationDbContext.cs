using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Data.EntityConfiguration;

namespace Infra.Data.Context;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
     public DbSet<Product> Products { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
         Products = Set<Product>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=CleanArchDb;Username=jonadev;Password=123456789");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder builder){
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ProductConfiguration());
    }

}

