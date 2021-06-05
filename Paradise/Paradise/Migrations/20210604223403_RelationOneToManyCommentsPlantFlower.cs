using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class RelationOneToManyCommentsPlantFlower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlowerId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FlowerId",
                table: "Comments",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PlantId",
                table: "Comments",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Flowers_FlowerId",
                table: "Comments",
                column: "FlowerId",
                principalTable: "Flowers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Plants_PlantId",
                table: "Comments",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Flowers_FlowerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Plants_PlantId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FlowerId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PlantId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "FlowerId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "Comments");
        }
    }
}
