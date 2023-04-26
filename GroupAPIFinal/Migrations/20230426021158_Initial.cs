using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupAPIFinal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavFruit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavMeat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavCuisine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hobby1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavBand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavArtist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavGenre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocation", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FavCuisine", "FavFruit", "FavMeal", "FavMeat" },
                values: new object[,]
                {
                    { 1, "Korean", "Apple", "Lunch", "Chicken" },
                    { 2, "German", "Banana", "Dinner", "Steak" },
                    { 3, "American", "Grape", "Dinner", "Salmon" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Hobby1", "Hobby2", "Hobby3", "Hobby4" },
                values: new object[,]
                {
                    { 1, "Painting", "Drawing", "Photography", "Knitting" },
                    { 2, "Video Games", "Shopping", "Hiking", "Writing" },
                    { 3, "Traveling", "Biking", "Golfing", "Movie Watching" }
                });

            migrationBuilder.InsertData(
                table: "Music",
                columns: new[] { "Id", "FavArtist", "FavBand", "FavGenre", "FavSong" },
                values: new object[,]
                {
                    { 1, "Elvis Pressley", "The Beatles", "Classic", "Here Comes The Sun" },
                    { 2, "Micheal Jackson", "Dave Matthews Band", "Pop", "Billie Jean" },
                    { 3, "George Strait", "AC/DC", "Country", "Troubadour" }
                });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "Birthdate", "Major", "Name", "year" },
                values: new object[,]
                {
                    { 1, "June 3rd 2003", "Information Technology", "Drew Rawlins", 2025 },
                    { 2, "January 12th 2002", "Information Technology", "Jacob Collier", 2025 },
                    { 3, "January 22nd 2003", "Information Technology", "Dylan Mullarkey", 2025 }
                });

            migrationBuilder.InsertData(
                table: "UserLocation",
                columns: new[] { "Id", "AreaCode", "City", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, 513, "Cincinnati", "Ohio", 45244 },
                    { 2, 513, "Milford", "Ohio", 45150 },
                    { 3, 614, "Columbus", "Ohio", 43004 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Music");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserLocation");
        }
    }
}
