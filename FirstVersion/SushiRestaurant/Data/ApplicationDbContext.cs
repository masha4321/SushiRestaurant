using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SushiRestaurant.Models;

namespace SushiRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SushiRestaurant.Models.Customer>? Customer { get; set; }
        public DbSet<SushiRestaurant.Models.Product>? Product { get; set; }
        public DbSet<SushiRestaurant.Models.Category>? Category { get; set; }
    }
}