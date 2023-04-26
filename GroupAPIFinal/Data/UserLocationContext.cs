using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Data;

public class UserLocationContext : DbContext
{
    public UserLocationContext(DbContextOptions<UserLocationContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserLocationInfo>().HasData(
            new UserLocationInfo { Id = 1, State = "Ohio", City = "Cincinnati", AreaCode = 513, ZipCode = 45244},
            new UserLocationInfo { Id = 2, State = "Ohio", City = "Milford", AreaCode = 513, ZipCode = 45150 },
            new UserLocationInfo { Id = 3, State = "Ohio", City = "Columbus", AreaCode = 614, ZipCode = 43004 }//add new data here, copy line above and change fields
            );
    }

    public DbSet<UserLocationInfo> Location { get; set; }
}
