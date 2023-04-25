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
                new UserHobbies { Id = 2, Hobby1 = "Ohio", Hobby2 = "Milford", Hobby3 = 513, Hobby4 = 45150 },
                new UserHobbies { Id = 3, Hobby1 = "Ohio", Hobby2 = "Columbus", Hobby3 = 614, Hobby4 = 43004 }//add new data here, copy line above and change fields
                );
        }

        public DbSet<UserHobbies> Hobbies { get; set; }
    }
}
