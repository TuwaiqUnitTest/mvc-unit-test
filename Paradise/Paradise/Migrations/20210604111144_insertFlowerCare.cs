using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class insertFlowerCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CareFlower",
                columns: new[] { "ID", "FlowerId", "LevelCare", "Place", "Size" },
                values: new object[,]
                {
                    { 1, 1, "Easy", "indoors", "6 to 8 inches" },
                    { 2, 2, "Easy", "outdoors", "6 to 9 inches" },
                    { 3, 3, "Easy", "indoors", "3 to 4 inches" },
                    { 4, 4, "Hard", "outdoors", "12 inches" },
                    { 5, 5, "Medium", "outdoor", "3 to 5 inches" },
                    { 6, 6, "Medium", "outdoors", "2 to 3 inches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CareFlower",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
