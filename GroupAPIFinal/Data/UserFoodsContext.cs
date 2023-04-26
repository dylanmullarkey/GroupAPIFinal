using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroupAPIFinal.Data;
    public class UserFoodsContext : DbContext
    {
        public UserFoodsContext(DbContextOptions<UserFoodsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserFoods>().HasData(
                new UserFoods { Id = 1, FavMeal = "Lunch", FavFruit = "Apple", FavMeat = "Chicken", FavCuisine = "Korean"},
                new UserFoods { Id = 2, FavMeal = "Dinner", FavFruit = "Banana", FavMeat = "Steak", FavCuisine = "German" },
                new UserFoods { Id = 3, FavMeal = "Dinner", FavFruit = "Grape", FavMeat = "Salmon", FavCuisine = "American" }
                //add new data here, copy line above and change fields
                );
        }

        public DbSet<UserFoods> Foods { get; set; }
    }

