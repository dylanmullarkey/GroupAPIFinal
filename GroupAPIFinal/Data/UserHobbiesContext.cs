using FinalProjectNetAPI.Data;
using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Data
{
    public class UserHobbiesContext
    {
        public UserHobbiesContext(DbContextOptions<UserHobbiesContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserHobbies>().HasData(
                new UserHobbies { Id = 1,Hobby1 = "Painting", Hobby2 = "Drawing", Hobby3 = "Photography", Hobby4 = "Knitting" },
                new UserHobbies { Id = 2, Hobby1 = "Video Games", Hobby2 = "Shopping", Hobby3 = "Hiking", Hobby4 = "Writing" },
                new UserHobbies { Id = 3, Hobby1 = "Traveling", Hobby2 = "Biking", Hobby3 = "Golfing", Hobby4 = "Movie Watching" }//add new data here, copy line above and change fields
                );
        }

        public DbSet<UserHobbies> Hobbies { get; set; }
    }
}
