using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class mi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Bmr",
                value: 1700.0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Bmr",
                value: 1700.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "EatDay",
                value: new DateTime(2023, 4, 2, 12, 31, 33, 862, DateTimeKind.Local).AddTicks(5592));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Bmr",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Bmr",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "EatDay",
                value: new DateTime(2023, 4, 1, 23, 53, 41, 114, DateTimeKind.Local).AddTicks(2969));
        }
    }
}
