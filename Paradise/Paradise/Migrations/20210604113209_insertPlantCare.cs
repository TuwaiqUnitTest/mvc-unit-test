using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class insertPlantCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarePlant",
                columns: new[] { "ID", "LevelCare", "Place", "PlantId", "Size" },
                values: new object[,]
                {
                    { 1, "Easy", "indoors", 1, "12 inches" },
                    { 2, "Easy", "indoors", 2, "14 inches" },
                    { 3, "Easy", "indoors", 3, "12 to 14 inches" },
                    { 4, "Easy", "indoors", 4, "8 to 12 inches" },
                    { 5, "Easy", "indoors", 5, "12 to 24 inches" },
                    { 6, "Medium", "outdoors", 6, "20 inches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarePlant",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
