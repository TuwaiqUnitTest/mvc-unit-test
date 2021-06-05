using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class updateTablesAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flowers",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Flowers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Message",
                value: "Cornflower: You'll love these bright-blue beauties as much as the birds and butterflies do.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Message",
                value: "Verbena: These tiny beauties flower profusely until first frost, brightening beds, borders, and hanging baskets even in part shade. They'll even tolerate the hot, dry summer days in the South leading up to a cooler fall.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Message",
                value: "Colchicum: You might know colchicum by its other name: autumn crocus. As you would expect, they do bloom between August and September, but without any foliage. The leaves only appear in the spring before dying back.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "Message",
                value: @"Aglaonema: If you're more of a waterer, an excellent plant is a Chinese evergreen,Fried says.Aglaonema can withstand excess H2O,
              and it comes in a spectrum of colors,
              including green,
              pink,
              white,
              and red.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                column: "Message",
                value: "Chinese Money Plant: Pilea peperomioides grows best in a shady spot (or winter windowsill) with weekly watering, according to The Little Book of House Plants and Other Greenery.");

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "FlowerId", "Message", "PlantId" },
                values: new object[] { 6, 0, "Chinese Money Plant: grows best in a shady spot (or winter windowsill)", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flowers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Flowers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Comments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Message",
                value: "You'll love these bright-blue beauties as much as the birds and butterflies do.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Message",
                value: "These tiny beauties flower profusely until first frost, brightening beds, borders, and hanging baskets even in part shade. They'll even tolerate the hot, dry summer days in the South leading up to a cooler fall.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Message",
                value: "You might know colchicum by its other name: autumn crocus. As you would expect, they do bloom between August and September, but without any foliage. The leaves only appear in the spring before dying back.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "Message",
                value: @"If you're more of a waterer, an excellent plant is a Chinese evergreen,Fried says.Aglaonema can withstand excess H2O,
              and it comes in a spectrum of colors,
              including green,
              pink,
              white,
              and red.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                column: "Message",
                value: "Pilea peperomioides grows best in a shady spot (or winter windowsill) with weekly watering, according to The Little Book of House Plants and Other Greenery.");
        }
    }
}
