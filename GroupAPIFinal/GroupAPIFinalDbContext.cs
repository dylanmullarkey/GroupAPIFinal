using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

public class GroupAPIFinalDbContext : DbContext
{
    public MyWebAPIDBContext(DbContextOptions<MyWebAPIDBContext> options)

 : base(options)

    {
        Database.EnsureCreated();
    }
    public DbSet<UserInfo> TeamMembers { get; set; }

    public DbSet<UserLocationInfo> UserLocation { get; set; }

    public DbSet<UserHobbies> Hobbies { get; set; }

    public DbSet<UserFoods> Food { get; set; }

    public DbSet<UserMusic> Music { get; set; }

}