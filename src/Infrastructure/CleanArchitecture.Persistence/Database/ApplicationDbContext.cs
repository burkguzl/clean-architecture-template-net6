using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Paper", Value = 100, Quantity = 1000, CreateDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Pencil", Value = 120, Quantity = 1500, CreateDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Eraser", Value = 50, Quantity = 1500, CreateDate = DateTime.Now });

            base.OnModelCreating(modelBuilder);
        }
    }
}
