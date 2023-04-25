using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectNetAPI.Data;

public class UserLocationContext : DbContext
{
    public UserLocationContext(DbContextOptions<UserLocationContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserLocationInfo>().HasData(
            new UserLocationInfo { Id = 1, State = "Ohio", City = "Cincinnati", AreaCode = 513, ZipCode = 45244},
            new UserLocationInfo { }//add new data here, copy line above and change fields
            );
    }

    public DbSet<UserLocationInfo> Location { get; set; }
}
