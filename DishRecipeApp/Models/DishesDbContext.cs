using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishRecipeApp.Models
{
    public class DishesDbContext : IdentityDbContext
    {
        public DishesDbContext(DbContextOptions<DishesDbContext> options) : base(options) {}

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //modelBuilder.Entity<Expense>()
        //    //   .HasMany(c => c.Comments)
        //    //   .WithOne(e => e.Expense)
        //    //   .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Dish>()
        //        .HasMany(r => r.Reviews)
        //        .WithOne(d => d.Dish)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Ingredient>()
        //       .HasMany(d => d.Dishes)
        //       .WithOne(i => i.Ingredient)
        //       .OnDelete(DeleteBehavior.Cascade);
        //}
    }
}