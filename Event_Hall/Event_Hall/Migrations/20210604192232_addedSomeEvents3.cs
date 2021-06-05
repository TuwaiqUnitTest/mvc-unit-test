using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedSomeEvents3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Events_HallId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "HallModelId",
                table: "Attendees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[] { 122222, "Entrepreneur Elon Musk is a man with many plans. The founder of PayPal, Tesla Motors and SpaceX sits down with TED curator Chris Anderson to share details about his visionary projects, which include a mass-marketed electric car, a solar energy leasing company and a fully reusable rocket.", "2 Hours", 1, "https://c.ndtvimg.com/2021-03/9op9k9ko_elon-musk-reuters_625x300_25_March_21.jpg", "the Mind Behind Tesla, Spacex and Solarcity", 2, "Sunday, August 12, 2021 3:30:00 PM" });

            migrationBuilder.UpdateData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Field", "Name" },
                values: new object[] { "steven@galaxybrain.com", "Science", "Steven Hawking" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_HallId",
                table: "Events",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_HallModelId",
                table: "Attendees",
                column: "HallModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Halls_HallModelId",
                table: "Attendees",
                column: "HallModelId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Halls_HallModelId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Events_HallId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_HallModelId",
                table: "Attendees");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 122222);

            migrationBuilder.DropColumn(
                name: "HallModelId",
                table: "Attendees");

            migrationBuilder.UpdateData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Field", "Name" },
                values: new object[] { "hanan@gmail.com", "Gaming", "Hanan Alhakami" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_HallId",
                table: "Events",
                column: "HallId",
                unique: true);
        }
    }
}
