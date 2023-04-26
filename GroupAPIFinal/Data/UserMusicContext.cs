using GroupAPIFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Data
{
    public class UserMusicContext
    {
        public UserMusicContext(DbContextOptions<UserMusicContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserMusic>().HasData(
                new UserMusic { Id = 1, FavBand = "The Beatles", FavArtist = "Elvis Pressley", FavSong = "Here Comes The Sun", FavGenre = "Classic" },
                new UserMusic { Id = 1, FavBand = "Dave Matthews Band", FavArtist = "Micheal Jackson", FavSong = "Billie Jean", FavGenre = "Pop" },
                new UserMusic { Id = 1, FavBand = "AC/DC", FavArtist = "George Strait", FavSong = "Troubadour", FavGenre = "Country" }//add new data here, copy line above and change fields
                );
        }

        public DbSet<UserMusic> Music { get; set; }
    }
}
