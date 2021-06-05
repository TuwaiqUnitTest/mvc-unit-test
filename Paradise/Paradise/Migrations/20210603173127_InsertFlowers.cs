using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class InsertFlowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "ID", "Image", "Name", "Tempreture" },
                values: new object[,]
                {
                    { 1, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pink-dahlias-royalty-free-image-513204805-1562778270.jpg?crop=0.445xw:1.00xh;0.450xw,0&resize=980:*", "Dahlias", "20°–22°C" },
                    { 2, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cornflowers-royalty-free-image-104696040-1562778695.jpg?crop=0.445xw:1.00xh;0.386xw,0&resize=980:*", "Cornflower", "15°-26°C" },
                    { 3, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cosmos-flowers-royalty-free-image-184971248-1562779148.jpg?crop=0.445xw:1.00xh;0.382xw,0&resize=980:*", "Cosmos", "16°C" },
                    { 4, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/verbena-royalty-free-image-471346036-1562778134.jpg?crop=0.445xw:1.00xh;0.439xw,0&resize=980:*", "Verbena", "15°C" },
                    { 5, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/colchicum-autumnale-autumn-crocus-1532630291.jpg?crop=0.4449685534591195xw:1xh;center,top&resize=980:*", "Colchicum", "20°-25°C" },
                    { 6, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/purple-aster-daisies-1532630286.jpg?crop=0.447xw:1.00xh;0.366xw,0&resize=980:*", "Asters", "16°–17°C" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
