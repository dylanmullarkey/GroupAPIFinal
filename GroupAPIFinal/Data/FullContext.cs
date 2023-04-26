using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroupAPIFinal.Data;
public class FullContext : DbContext
{
    public FullContext(DbContextOptions<FullContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserFoods>().HasData(
            new UserFoods { Id = 1, FavMeal = "Lunch", FavFruit = "Apple", FavMeat = "Chicken", FavCuisine = "Korean" },
            new UserFoods { Id = 2, FavMeal = "Dinner", FavFruit = "Banana", FavMeat = "Steak", FavCuisine = "German" },
            new UserFoods { Id = 3, FavMeal = "Dinner", FavFruit = "Grape", FavMeat = "Salmon", FavCuisine = "American" }
            );
        builder.Entity<UserHobbies>().HasData(
            new UserHobbies { Id = 1, Hobby1 = "Painting", Hobby2 = "Drawing", Hobby3 = "Photography", Hobby4 = "Knitting" },
            new UserHobbies { Id = 2, Hobby1 = "Video Games", Hobby2 = "Shopping", Hobby3 = "Hiking", Hobby4 = "Writing" },
            new UserHobbies { Id = 3, Hobby1 = "Traveling", Hobby2 = "Biking", Hobby3 = "Golfing", Hobby4 = "Movie Watching" }//add new data here, copy line above and change fields
            );
        builder.Entity<UserInfo>().HasData(
            new UserInfo { Id = 1, Name = "Drew Rawlins", Birthdate = 2003 / 6 / 03, Major = "Information Technology", year = 2025 },
            new UserInfo { Id = 2, Name = "Jacob Collier", Birthdate = 2002 / 11 / 18, Major = "Information Technology", year = 2025 },
            new UserInfo { Id = 3, Name = "Dylan Mullarkey", Birthdate = , Major = "Information Technology", year = 2025 }//add new data here, copy line above and change fields
            );
        builder.Entity<UserLocationInfo>().HasData(
            new UserLocationInfo { Id = 1, State = "Ohio", City = "Cincinnati", AreaCode = 513, ZipCode = 45244 },
            new UserLocationInfo { Id = 2, State = "Ohio", City = "Milford", AreaCode = 513, ZipCode = 45150 },
            new UserLocationInfo { Id = 3, State = "Ohio", City = "Columbus", AreaCode = 614, ZipCode = 43004 }
            );
        builder.Entity<UserMusic>().HasData(
            new UserMusic { Id = 1, FavBand = "The Beatles", FavArtist = "Elvis Pressley", FavSong = "Here Comes The Sun", FavGenre = "Classic" },
            new UserMusic { Id = 1, FavBand = "Dave Matthews Band", FavArtist = "Micheal Jackson", FavSong = "Billie Jean", FavGenre = "Pop" },
            new UserMusic { Id = 1, FavBand = "AC/DC", FavArtist = "George Strait", FavSong = "Troubadour", FavGenre = "Country" }
            );

    }

    public DbSet<UserFoods> Foods { get; set; }
    public DbSet<UserHobbies> Hobbies { get; set; }
    public DbSet<UserInfo> UserInfo { get; set; }
    public DbSet<UserLocationInfo> UserLocation { get; set; }
    public DbSet<UserMusic> Music { get; set; }
}