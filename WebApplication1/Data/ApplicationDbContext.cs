using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Action",
                DisplayOrder = 1
            },
            new Category
            {
                Id = 2,  // Ensure each record has a unique Id
                Name = "Adventure",
                DisplayOrder = 2
            },
            new Category
            {
                Id = 3,
                Name = "Comedy",
                DisplayOrder = 3
            },
            new Category
            {
                Id = 4,
                Name = "SciFi",
                DisplayOrder = 3
            },
            new Category
            {
                Id = 5,
                Name = "History",
                DisplayOrder = 3
            }
        );
    }
}