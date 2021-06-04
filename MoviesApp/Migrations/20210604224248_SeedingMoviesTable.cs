using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApp.Migrations
{
    public partial class SeedingMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "CoverURL", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Davis LLC", 4 },
                    { 2, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Rodriguez Inc", 6 },
                    { 3, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Oates Inc", 6 },
                    { 4, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Jackson Group", 7 },
                    { 5, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Edwards and Sons", 2 },
                    { 6, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Robertson LLC", 3 },
                    { 7, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Peterson LLC", 9 },
                    { 8, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Kirby LLC", 5 },
                    { 9, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Burrows LLC", 7 },
                    { 10, "https://i.pinimg.com/originals/c3/be/67/c3be67bf37cbd41fc762a3254e3ed6cd.jpg", "Thomas LLC", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
