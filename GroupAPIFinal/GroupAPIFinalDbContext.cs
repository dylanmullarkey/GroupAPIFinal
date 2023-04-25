using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

public class GroupAPIFinalContext : DbContext
{
    public GroupAPIFinalContext(DbContextOptions<GroupAPIFinalContext> options)

 : base(options)

    {

    }
    public DbSet<UserInfo> UserInfo { get; set; }

    public DbSet<UserLocationInfo> UserLocation { get; set; }

    public DbSet<UserHobbies> UserHobbies { get; set; }

    public DbSet<UserFoods> UserFoods { get; set; }

    public DbSet<UserMusic> UserMusic { get; set; }

}