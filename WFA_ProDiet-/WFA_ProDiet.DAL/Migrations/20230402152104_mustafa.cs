using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class mustafa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealDetails",
                keyColumns: new[] { "FoodID", "MealID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "ActivityLevel", "BirthDate", "Bmr", "Email", "FirstName", "Gender", "Height", "LastName", "Password", "PicturePath", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[] { 1, "NoActivitiy", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1700.0, "aaa", "Oğuz Kağan", "Man", 180, "Ünal", "aaa", null, 1500.0, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "ActivityLevel", "BirthDate", "Bmr", "Email", "FirstName", "Gender", "Height", "LastName", "Password", "PicturePath", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[] { 2, "MoreActive", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1700.0, "ikasapoglu@mail.com", "İlkiz", "Woman", 180, "Kasapoğlu", "bbb", null, 1500.0, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "CustomerId", "EatDay", "MealCalorie", "MealCarbohydrate", "MealFat", "MealProtein", "Name" },
                values: new object[] { 1, 1, new DateTime(2023, 4, 2, 12, 31, 33, 862, DateTimeKind.Local).AddTicks(5592), 500.0, 200.0, 50.0, 100.0, "Breakfast" });

            migrationBuilder.InsertData(
                table: "MealDetails",
                columns: new[] { "FoodID", "MealID", "Quantity" },
                values: new object[] { 1, 1, 3 });
        }
    }
}
