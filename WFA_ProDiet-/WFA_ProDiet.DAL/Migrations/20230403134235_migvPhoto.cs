using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class migvPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "PicturePath",
                value: ".\\Resources\\Bıldırcın.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "PicturePath",
                value: null);
        }
    }
}
