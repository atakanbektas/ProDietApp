using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class migvUpdatedPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 18,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Ayçiçek Yağı.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 22,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Margarin.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 23,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Margarin.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Dereotu.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 34,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Hardal Toz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 36,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Hindistan cevizi toz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 41,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Kırmızı Biber (toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 42,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Kimyon.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 44,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Maydonoz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 47,
                column: "PicturePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 48,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\tarçın toz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 54,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\işkembe.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 57,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Tarhana.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 58,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Tarhana.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 60,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Yulaf.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 62,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\istakoz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 63,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\istiridye.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 73,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Turşu.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 280,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Sarımsak Baş.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 281,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Sarımsak Toz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 295,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\italyan salata sosu.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 314,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Yoğurt Yağlı.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 334,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Buğday.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 18,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Ayçiçeği Yağı.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 22,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Margarin (kahvaltılık).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 23,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Margarin (kahvaltılık).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Dere Otu (Kuru).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 34,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Hardal (Toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 36,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Hindistan cevizi (Toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 41,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Kırmızıbiber (toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 42,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Kimyon (Toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 44,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Maydonoz (kuru).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 47,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Sofra Tuzu.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 48,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Tarçın (Toz).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 54,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\İşkembe.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 57,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Tarhana (Acı).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 58,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Tarhana (tatlı).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 60,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Yulaf çorbası.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 62,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\İstakoz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 63,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\İstiridye.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 73,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Turşu (Salatalık).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 280,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Sarmısak Baş.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 281,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Sarmısak Toz.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 295,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\İtalyan salata sosu.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 314,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Yoğurt (Yağlı).png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 334,
                column: "PicturePath",
                value: "..\\..\\..\\Resources\\Buğday (durum).png");
        }
    }
}
