using Microsoft.EntityFrameworkCore;
using CoreApp.Domain.Models;

namespace CoreApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        DbSet<Category> Category {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Category>().HasData
            (
                new Category { clientId = 100, clientCategory = "Fruits and Vegetables" }, // Id set manually due to in-memory provider
                new Category { clientId = 101, clientCategory = "Dairy" }
            );

        }
    }



}