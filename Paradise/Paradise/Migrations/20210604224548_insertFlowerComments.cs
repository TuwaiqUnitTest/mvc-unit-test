using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class insertFlowerComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 1, 2, "You'll love these bright-blue beauties as much as the birds and butterflies do.", 0 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 2, 4, "These tiny beauties flower profusely until first frost, brightening beds, borders, and hanging baskets even in part shade. They'll even tolerate the hot, dry summer days in the South leading up to a cooler fall.", 0 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 3, 5, "You might know colchicum by its other name: autumn crocus. As you would expect, they do bloom between August and September, but without any foliage. The leaves only appear in the spring before dying back.", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
