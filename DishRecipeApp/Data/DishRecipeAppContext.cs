using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DishRecipeApp.Models;

namespace DishRecipeApp.Data
{
    public class DishRecipeAppContext : DbContext
    {
        public DishRecipeAppContext (DbContextOptions<DishRecipeAppContext> options)
            : base(options)
        {
        }

        public DbSet<DishRecipeApp.Models.Dish> Dish { get; set; }
    }
}
