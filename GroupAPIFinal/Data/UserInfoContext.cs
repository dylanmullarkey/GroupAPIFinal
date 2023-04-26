using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Data
{
    public class UserInfoContext
    {
        public UserInfoContext(DbContextOptions<UserHobbiesContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserInfo>().HasData(
                new UserInfo { Id = 1, Name = "Drew Rawlins", Birthdate = 2003/6/03, Major = "Information Technology", year = 2025 },
                new UserInfo { Id = 2, Name = "Jacob Collier", Birthdate = 2002/11/18, Major = "Information Technology", year = 2025 },
                new UserInfo { Id = 3, Name = "Dylan Mullarkey", Birthdate = 2003/2/04, Major = "Information Technology", year = 2025 }//add new data here, copy line above and change fields
                );
        }

        public DbSet<UserHobbies> Hobbies { get; set; }
    }
}