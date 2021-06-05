using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Paradise.Migrations
{
    public partial class relationsFlowerPlantCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cares");

            migrationBuilder.CreateTable(
                name: "CareFlower",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LevelCare = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    FlowerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareFlower", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CareFlower_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "Flowers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarePlant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LevelCare = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarePlant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarePlant_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareFlower_FlowerId",
                table: "CareFlower",
                column: "FlowerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarePlant_PlantId",
                table: "CarePlant",
                column: "PlantId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareFlower");

            migrationBuilder.DropTable(
                name: "CarePlant");

            migrationBuilder.CreateTable(
                name: "Cares",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LevelCare = table.Column<string>(type: "text", nullable: true),
                    Place = table.Column<string>(type: "text", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cares", x => x.ID);
                });
        }
    }
}
