using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class insertPlantComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 4, 0, @"If you're more of a waterer, an excellent plant is a Chinese evergreen,Fried says.Aglaonema can withstand excess H2O,
              and it comes in a spectrum of colors,
              including green,
              pink,
              white,
              and red.", 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 5, 0, "Pilea peperomioides grows best in a shady spot (or winter windowsill) with weekly watering, according to The Little Book of House Plants and Other Greenery.", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
