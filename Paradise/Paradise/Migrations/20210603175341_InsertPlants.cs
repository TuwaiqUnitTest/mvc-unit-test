using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradise.Migrations
{
    public partial class InsertPlants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "ID", "Image", "Name", "Tempreture" },
                values: new object[,]
                {
                    { 1, "https://images.unsplash.com/photo-1598880940080-ff9a29891b85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60", "Pothos", "15°-29°C" },
                    { 2, "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654887-1427228256-chinese-evergreen-plants-little-water.jpg?crop=0.970xw:0.974xh;0.0208xw,0.0161xh&resize=768:*", "Aglaonema", "18°-24°C" },
                    { 3, "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654852-jade-plant-1589561938.jpg?crop=0.6677678150070788xw:1xh;center,top&resize=768:*", "Jade Plant", "18°-24°C" },
                    { 4, "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557177323-pilea-peperomioides-money-plant-in-the-pot-single-royalty-free-image-917778022-1557177295.jpg?crop=1.00xw:0.668xh;0,0.269xh&resize=768:*", "Chinese Money Plant", "13°-30°C " },
                    { 5, "https://images.unsplash.com/photo-1484885192048-9696607347da?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60", "Aloe", "13°-27°C" },
                    { 6, "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557255932-the-sill-potted-plant-calathea-medallion-prospect-black-7-1500x-progressive-1557255913.jpg?crop=1.00xw:0.774xh;0,0.174xh&resize=768:*", "Calathea", "15°-23°C " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
