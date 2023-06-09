﻿using BulkyWebECommerce_Temp.Model;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebECommerce_Temp.Data
{
    public class ApplicationDbContaxt : DbContext
    {
        public ApplicationDbContaxt(DbContextOptions<ApplicationDbContaxt> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }

    }
}
