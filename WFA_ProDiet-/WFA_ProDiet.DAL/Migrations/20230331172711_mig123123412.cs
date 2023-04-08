using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class mig123123412 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    ActivityLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetWeight = table.Column<double>(type: "float", nullable: true),
                    TargetDate = table.Column<DateTime>(type: "date", nullable: true),
                    TargetCalorie = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    MeasureType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EatDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealCalorie = table.Column<double>(type: "float", nullable: true),
                    MealCarbohydrate = table.Column<double>(type: "float", nullable: true),
                    MealProtein = table.Column<double>(type: "float", nullable: true),
                    MealFat = table.Column<double>(type: "float", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "MealDetails",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDetails", x => new { x.MealID, x.FoodID });
                    table.ForeignKey(
                        name: "FK_MealDetails_Foods",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodId");
                    table.ForeignKey(
                        name: "FK_MealDetails_Meals",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Av Hayvanları" },
                    { 2, "Balıklar" },
                    { 3, "Bitkisel Yağlar" },
                    { 4, "Çeşniler" },
                    { 5, "Çorbalar" },
                    { 6, "Deniz Ürünleri" },
                    { 7, "Diğer Besinler" },
                    { 8, "Ekmek Vb. Ürünler" },
                    { 9, "Et Ürünleri" },
                    { 10, "Hayvansal Yağlar" },
                    { 11, "İçecekler" },
                    { 12, "Kırmızı Etler" },
                    { 13, "Kurubaklagiller" },
                    { 14, "Kümes Hayvanları" },
                    { 15, "Meyveler" },
                    { 16, "Peynirler" },
                    { 17, "Sakatatlar" },
                    { 18, "Sebzeler" },
                    { 19, "Soslar" },
                    { 20, "Süt ve Ürünleri" },
                    { 21, "Şeker ve Şeker Ürünleri" },
                    { 22, "Tahıl Ürünleri" },
                    { 23, "Tatlılar" },
                    { 24, "Yumurtalar" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "ActivityLevel", "BirthDate", "Email", "FirstName", "Gender", "Height", "LastName", "Password", "PicturePath", "TargetCalorie", "TargetDate", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, "NoActivitiy", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aaa", "Oğuz Kağan", "Man", 180, "Ünal", "aaa", null, 1500.0, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 },
                    { 2, "MoreActive", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ikasapoglu@mail.com", "İlkiz", "Woman", 180, "Kasapoğlu", "bbb", null, 1500.0, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 45.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 1, 192.0, 0.0, 1, 12.1, "Gram", "Bıldırcın", null, 19.600000000000001 },
                    { 2, 294.0, 0.0, 1, 23.800000000000001, "Gram", "Güvercin", null, 18.5 },
                    { 3, 181.0, 0.0, 1, 9.3000000000000007, "Gram", "Sülün", null, 22.699999999999999 },
                    { 4, 162.0, 0.0, 1, 8.0, "Gram", "Tavşan", null, 21.0 },
                    { 5, 175.0, 0.0, 2, 9.0, "Gram", "Alabalık", null, 18.300000000000001 },
                    { 6, 336.0, 0.0, 2, 0.29999999999999999, "Gram", "Balık Unu", null, 78.0 },
                    { 7, 193.0, 0.0, 2, 14.4, "Gram", "Kalkan", null, 148.0 },
                    { 8, 164.0, 0.0, 2, 5.5999999999999996, "Gram", "Kılıç", null, 26.300000000000001 },
                    { 9, 93.0, 0.0, 2, 1.2, "Gram", "Levrek", null, 19.199999999999999 },
                    { 10, 96.0, 0.0, 2, 2.2999999999999998, "Gram", "Mersin", null, 17.699999999999999 },
                    { 11, 168.0, 0.0, 2, 7.2999999999999998, "Gram", "Palamut", null, 24.0 },
                    { 12, 160.0, 0.0, 2, 8.5999999999999996, "Gram", "Sardalya", null, 19.199999999999999 },
                    { 13, 205.0, 0.0, 2, 11.0, "Gram", "Sardalya (konserve)", null, 24.0 },
                    { 14, 155.0, 0.0, 2, 8.1999999999999993, "Gram", "Somon", null, 20.300000000000001 },
                    { 15, 289.0, 0.0, 2, 22.0, "Gram", "Ton", null, 22.800000000000001 },
                    { 16, 305.0, 0.0, 2, 25.100000000000001, "Gram", "Tuzlu Balık", null, 18.5 },
                    { 17, 159.0, 0.0, 2, 7.2999999999999998, "Gram", "Uskumru", null, 21.899999999999999 },
                    { 18, 884.0, 0.0, 3, 100.0, "Gram", "Ayçiçeği Yağı", null, 0.0 },
                    { 19, 884.0, 0.0, 3, 100.0, "Gram", "Fındık Yağı", null, 0.0 },
                    { 20, 884.0, 0.0, 3, 100.0, "Gram", "Haşhaş Yağı", null, 0.0 },
                    { 21, 884.0, 0.0, 3, 100.0, "Gram", "Keten tohumu yağı", null, 0.0 },
                    { 22, 719.0, 0.90000000000000002, 3, 80.5, "Gram", "Margarin (kahvaltılık)", null, 0.0 },
                    { 23, 720.0, 0.0, 3, 82.0, "Gram", "Margarin (kahvaltılık)", null, 0.0 },
                    { 24, 884.0, 0.0, 3, 100.0, "Gram", "Mısırözü Yağı", null, 0.0 },
                    { 25, 900.0, 0.0, 3, 100.0, "Gram", "Nebati Yağ", null, 0.0 },
                    { 26, 884.0, 0.0, 3, 100.0, "Gram", "Palmiye Yağı", null, 0.0 },
                    { 27, 884.0, 0.0, 3, 100.0, "Gram", "Pamuk Yağı", null, 0.0 },
                    { 28, 884.0, 0.0, 3, 100.0, "Gram", "Soya Yağı", null, 0.0 },
                    { 29, 884.0, 0.0, 3, 100.0, "Gram", "Susam Yağı", null, 0.0 },
                    { 30, 884.0, 0.0, 3, 100.0, "Gram", "Yerfıstığı Yağı", null, 0.0 },
                    { 31, 884.0, 0.0, 3, 100.0, "Gram", "Zeytin Yağı", null, 0.0 },
                    { 32, 313.0, 75.0, 4, 8.4000000000000004, "Gram", "Defne Yaprağı", null, 7.5999999999999996 },
                    { 33, 253.0, 56.0, 4, 4.4000000000000004, "Gram", "Dere Otu (Kuru)", null, 20.0 },
                    { 34, 469.0, 35.0, 4, 29.0, "Gram", "Hardal (Toz)", null, 25.0 },
                    { 35, 533.0, 23.699999999999999, 4, 45.0, "Gram", "Haşhaş Tohumu", null, 18.0 },
                    { 36, 525.0, 50.0, 4, 36.299999999999997, "Gram", "Hindistan cevizi (Toz)", null, 6.4000000000000004 },
                    { 37, 5.0, 1.0, 4, 0.0, "DessertSpoon", "Kabartma tozu", null, 0.0 },
                    { 38, 255.0, 65.0, 4, 3.2999999999999998, "Gram", "Karabiber", null, 11.0 },
                    { 39, 323.0, 61.200000000000003, 4, 20.100000000000001, "Gram", "Karanfil", null, 6.0 },
                    { 40, 276.0, 64.0, 4, 7.4000000000000004, "Gram", "Kekik", null, 9.0999999999999996 },
                    { 41, 318.0, 57.0, 4, 17.300000000000001, "Gram", "Kırmızıbiber (toz)", null, 12.0 },
                    { 42, 375.0, 44.200000000000003, 4, 22.300000000000001, "Gram", "Kimyon (Toz)", null, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 43, 54.0, 13.1, 4, 0.10000000000000001, "Gram", "Kuş üzümü", null, 1.7 },
                    { 44, 276.0, 52.0, 4, 4.4000000000000004, "Gram", "Maydonoz (kuru)", null, 22.399999999999999 },
                    { 45, 245.0, 29.800000000000001, 4, 4.9000000000000004, "Gram", "Nane (Kuru)", null, 15.1 },
                    { 46, 310.0, 65.0, 4, 6.5, "Gram", "Safran", null, 11.4 },
                    { 47, 0.0, 0.0, 4, 0.0, "Gram", "Sofra Tuzu", null, 0.0 },
                    { 48, 261.0, 80.0, 4, 3.2000000000000002, "Gram", "Tarçın (Toz)", null, 3.8999999999999999 },
                    { 49, 347.0, 71.0, 4, 6.0, "Gram", "Zencefil", null, 9.0999999999999996 },
                    { 50, 354.0, 65.299999999999997, 4, 10.1, "Gram", "Zerdecal", null, 8.1999999999999993 },
                    { 51, 295.0, 50.0, 5, 1.2, "Gram", "Bezelye", null, 21.0 },
                    { 52, 219.0, 45.399999999999999, 5, 1.0, "Gram", "Domates", null, 7.0 },
                    { 53, 274.0, 51.299999999999997, 5, 1.3999999999999999, "Gram", "Ezogelin", null, 14.0 },
                    { 54, 342.0, 52.0, 5, 6.0, "Gram", "İşkembe", null, 20.0 },
                    { 55, 235.0, 37.5, 5, 1.0, "Gram", "Mercimek", null, 19.0 },
                    { 56, 227.0, 43.200000000000003, 5, 1.1000000000000001, "Gram", "Sebze", null, 11.0 },
                    { 57, 290.0, 59.0, 5, 1.5, "Gram", "Tarhana (Acı)", null, 12.0 },
                    { 58, 280.0, 61.0, 5, 0.40000000000000002, "Gram", "Tarhana (tatlı)", null, 8.0 },
                    { 59, 252.0, 52.0, 5, 1.3, "Gram", "Yayla", null, 8.0 },
                    { 60, 318.0, 62.0, 5, 5.0, "Gram", "Yulaf çorbası", null, 6.2999999999999998 },
                    { 61, 262.0, 3.2999999999999998, 6, 15.0, "Gram", "Havyar", null, 26.899999999999999 },
                    { 62, 91.0, 0.5, 6, 1.8999999999999999, "Gram", "İstakoz", null, 16.899999999999999 },
                    { 63, 90.0, 5.0, 6, 5.0, "Piece", "İstiridye", null, 5.0 },
                    { 64, 91.0, 1.5, 6, 0.80000000000000004, "Gram", "Karides", null, 18.100000000000001 },
                    { 65, 95.0, 3.2999999999999998, 6, 2.2999999999999998, "Gram", "Midye", null, 14.1 },
                    { 66, 127.0, 0.0, 6, 5.2000000000000002, "Gram", "Yengeç (haşlanmış)", null, 20.100000000000001 },
                    { 67, 335.0, 0.0, 7, 0.10000000000000001, "Gram", "Jelatin", null, 86.0 },
                    { 68, 299.0, 48.299999999999997, 7, 24.0, "Gram", "Kakao", null, 17.0 },
                    { 69, 282.0, 39.0, 7, 1.6000000000000001, "Gram", "Maya (kuru)", null, 36.899999999999999 },
                    { 70, 86.0, 11.0, 7, 0.40000000000000002, "Gram", "Maya (Yaş)", null, 12.0 },
                    { 71, 12.0, 6.0, 7, 0.0, "Gram", "Sirke", null, 0.0 },
                    { 72, 595.0, 21.199999999999999, 7, 53.799999999999997, "Gram", "Tahin", null, 17.0 },
                    { 73, 10.0, 2.0, 7, 0.20000000000000001, "Gram", "Turşu (Salatalık)", null, 0.59999999999999998 },
                    { 74, 207.0, 1.1000000000000001, 7, 21.0, "Gram", "Zeytin (Siyah)", null, 1.8 },
                    { 75, 144.0, 2.7999999999999998, 7, 13.5, "Gram", "Zeytin (Yeşil)", null, 1.5 },
                    { 76, 276.0, 56.399999999999999, 8, 0.80000000000000004, "Gram", "Ekmek (buğday)", null, 9.0999999999999996 },
                    { 77, 243.0, 52.100000000000001, 8, 1.1000000000000001, "Gram", "Ekmek (çavdar)", null, 9.0999999999999996 },
                    { 78, 60.0, 0.0, 8, 0.0, "Slice", "Ekmek (kepek)", null, 0.0 },
                    { 79, 392.0, 73.400000000000006, 8, 4.5999999999999996, "Gram", "Galeta Unu", null, 12.6 },
                    { 80, 433.0, 0.0, 8, 13.9, "Gram", "Gramissini", null, 12.300000000000001 },
                    { 81, 371.0, 77.0, 8, 0.90000000000000002, "Gram", "İrmik", null, 11.4 },
                    { 82, 479.0, 60.399999999999999, 8, 21.300000000000001, "Gram", "Kraker (Peynirli)", null, 11.199999999999999 },
                    { 83, 384.0, 73.299999999999997, 8, 9.4000000000000004, "Gram", "Kraker (Sade)", null, 8.0 },
                    { 84, 433.0, 71.5, 8, 12.0, "Gram", "Kraker (tuzlu)", null, 9.8000000000000007 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 85, 369.0, 75.200000000000003, 8, 1.2, "Gram", "Makarna", null, 12.5 },
                    { 86, 298.0, 53.0, 8, 5.5999999999999996, "Gram", "Sandviç ekmeği", null, 8.1999999999999993 },
                    { 87, 271.0, 63.899999999999999, 8, 0.5, "Gram", "Yufka", null, 8.9000000000000004 },
                    { 88, 152.0, 33.0, 8, 0.29999999999999999, "Gram", "Yufka (Böreklik)", null, 3.1000000000000001 },
                    { 89, 182.0, 3.1000000000000001, 9, 10.6, "Gram", "Jambon", null, 17.600000000000001 },
                    { 90, 670.0, 0.20000000000000001, 9, 65.5, "Gram", "Kavurma", null, 20.0 },
                    { 91, 250.0, 0.0, 9, 13.9, "Gram", "Pastırma (çemenli)", null, 29.5 },
                    { 92, 269.0, 0.0, 9, 14.9, "Gram", "Pastırma (çemensiz)", null, 32.700000000000003 },
                    { 93, 450.0, 1.2, 9, 38.100000000000001, "Gram", "Salam", null, 23.800000000000001 },
                    { 94, 322.0, 2.3999999999999999, 9, 29.399999999999999, "Gram", "Sosis", null, 11.300000000000001 },
                    { 95, 452.0, 0.0, 9, 40.799999999999997, "Gram", "Sucuk", null, 21.399999999999999 },
                    { 96, 900.0, 0.0, 10, 100.0, "Gram", "Balık Yağı", null, 0.0 },
                    { 97, 758.0, 0.0, 10, 81.799999999999997, "Gram", "İçyağı", null, 4.0999999999999996 },
                    { 98, 902.0, 0.0, 10, 100.0, "Gram", "Kuyruk Yağı", null, 0.0 },
                    { 99, 890.0, 0.0, 10, 98.700000000000003, "Gram", "Sade Yağ (erimiş)", null, 0.29999999999999999 },
                    { 100, 100.0, 0.0, 10, 11.0, "DessertSpoon", "Tereyağı", null, 0.0 },
                    { 101, 315.0, 60.700000000000003, 11, 12.699999999999999, "Gram", "Adaçayı", null, 10.6 },
                    { 102, 80.0, 7.0, 11, 11.0, "Goblet", "Beyaz şarap", null, 8.0 },
                    { 103, 150.0, 13.0, 11, 0.0, "Piece", "Bira", null, 1.0 },
                    { 104, 231.0, 0.0, 11, 0.0, "Gram", "Cin", null, 0.0 },
                    { 105, 0.0, 0.0, 11, 0.0, "Bottle", "Cola (diyet)", null, 0.0 },
                    { 106, 160.0, 41.0, 11, 0.0, "Bottle", "Cola (normal)", null, 0.0 },
                    { 107, 16.0, 3.3999999999999999, 11, 0.0, "Gram", "Domates suyu", null, 0.69999999999999996 },
                    { 108, 39.0, 10.0, 11, 0.0, "Gram", "Gazoz", null, 0.0 },
                    { 109, 42.0, 6.7000000000000002, 11, 1.3999999999999999, "Gram", "Ihlamur", null, 0.40000000000000002 },
                    { 110, 5.0, 1.0, 11, 0.0, "Cup", "Kahve (instant)", null, 0.0 },
                    { 111, 75.0, 0.0, 11, 3.0, "Goblet", "Kırmızı şarap", null, 0.0 },
                    { 112, 21.0, 5.5999999999999996, 11, 0.0, "Gram", "Limonata", null, 0.0 },
                    { 113, 31.0, 8.0, 11, 0.0, "Gram", "Meyve suyu", null, 0.0 },
                    { 114, 45.0, 10.4, 11, 0.20000000000000001, "Gram", "Portakal Suyu", null, 0.69999999999999996 },
                    { 115, 71.0, 2.5, 11, 0.0, "Gram", "Rose (şarap)", null, 0.10000000000000001 },
                    { 116, 263.0, 0.0, 11, 0.0, "Gram", "Viski", null, 0.0 },
                    { 117, 275.0, 0.0, 11, 0.0, "Gram", "Votka", null, 0.0 },
                    { 118, 156.0, 0.0, 12, 8.0, "Gram", "Az yağlı dana eti", null, 19.699999999999999 },
                    { 119, 472.0, 0.0, 12, 47.0, "Gram", "Az yağlı domuz eti", null, 11.199999999999999 },
                    { 120, 247.0, 0.0, 12, 19.399999999999999, "Gram", "Az yağlı koyun eti", null, 16.800000000000001 },
                    { 121, 225.0, 0.0, 12, 15.800000000000001, "Gram", "Az yağlı sığır eti", null, 19.399999999999999 },
                    { 122, 145.0, 0.0, 12, 9.0, "Gram", "Keçi eti", null, 16.0 },
                    { 123, 190.0, 0.0, 12, 12.0, "Gram", "Orta yağlı dana eti", null, 19.100000000000001 },
                    { 124, 513.0, 0.0, 12, 52.0, "Gram", "Orta yağlı domuz eti", null, 10.199999999999999 },
                    { 125, 263.0, 0.0, 12, 21.300000000000001, "Gram", "Orta yağlı koyun eti", null, 16.5 },
                    { 126, 263.0, 0.0, 12, 20.399999999999999, "Gram", "Orta yağlı sığır eti", null, 18.5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 127, 223.0, 0.0, 12, 16.0, "Gram", "Yağlı dana eti", null, 18.5 },
                    { 128, 553.0, 0.0, 12, 57.0, "Gram", "Yağlı domuz eti", null, 9.0999999999999996 },
                    { 129, 310.0, 0.0, 12, 27.100000000000001, "Gram", "Yağlı koyun eti", null, 15.4 },
                    { 130, 301.0, 0.0, 12, 25.0, "Gram", "Yağlı sığır eti", null, 17.399999999999999 },
                    { 131, 560.0, 19.899999999999999, 13, 47.299999999999997, "Gram", "Ay çekirdeği", null, 24.0 },
                    { 132, 598.0, 19.0, 13, 54.200000000000003, "Gram", "Badem", null, 18.600000000000001 },
                    { 133, 338.0, 58.200000000000003, 13, 1.7, "Gram", "Bakla (İç)", null, 25.100000000000001 },
                    { 134, 349.0, 63.0, 13, 1.2, "Gram", "Barbunya", null, 22.899999999999999 },
                    { 135, 348.0, 63.0, 13, 1.0, "Gram", "Bezelye", null, 24.199999999999999 },
                    { 136, 343.0, 61.700000000000003, 13, 1.5, "Gram", "Börülce", null, 22.800000000000001 },
                    { 137, 651.0, 15.800000000000001, 13, 64.0, "Gram", "Ceviz", null, 14.800000000000001 },
                    { 138, 635.0, 20.5, 13, 60.5, "Gram", "Çam Fıstığı", null, 13.0 },
                    { 139, 634.0, 16.0, 13, 62.399999999999999, "Gram", "Fındık", null, 12.0 },
                    { 140, 560.0, 0.0, 13, 0.0, "Gram", "Fıstık", null, 0.0 },
                    { 141, 340.0, 61.299999999999997, 13, 1.6000000000000001, "Gram", "Kuru Fasulye (beyaz)", null, 22.300000000000001 },
                    { 142, 610.0, 16.699999999999999, 13, 50.0, "Gram", "Kabak Çekirdeği", null, 30.0 },
                    { 143, 581.0, 19.0, 13, 45.0, "Gram", "Kavun,Karpuz Çekirdeği", null, 25.0 },
                    { 144, 194.0, 42.100000000000001, 13, 1.5, "Gram", "Kestane", null, 2.8999999999999999 },
                    { 145, 131.0, 27.800000000000001, 13, 1.5, "Gram", "Kestane Haşlanmış", null, 2.0 },
                    { 146, 245.0, 53.0, 13, 2.2000000000000002, "Gram", "Kestane Kavrulmuş", null, 3.2000000000000002 },
                    { 147, 340.0, 60.100000000000001, 13, 1.1000000000000001, "Gram", "Mercimek", null, 24.699999999999999 },
                    { 148, 360.0, 61.0, 13, 4.7999999999999998, "Gram", "Nohut", null, 20.5 },
                    { 149, 268.0, 57.799999999999997, 13, 2.6000000000000001, "Gram", "Palamut Çekirdeği", null, 3.0 },
                    { 150, 403.0, 33.5, 13, 17.699999999999999, "Gram", "Soya Fasulyesi", null, 34.100000000000001 },
                    { 151, 356.0, 36.600000000000001, 13, 6.7000000000000002, "Gram", "Soya Unu (az yağlı)", null, 43.399999999999999 },
                    { 152, 326.0, 38.100000000000001, 13, 0.90000000000000002, "Gram", "Soya Unu (yağsız)", null, 47.0 },
                    { 153, 582.0, 17.600000000000001, 13, 53.399999999999999, "Gram", "Susam", null, 18.199999999999999 },
                    { 154, 594.0, 19.0, 13, 53.700000000000003, "Gram", "Şam Fıstığı", null, 19.300000000000001 },
                    { 155, 582.0, 20.600000000000001, 13, 48.700000000000003, "Gram", "Yer Fıstığı", null, 26.199999999999999 },
                    { 156, 160.0, 0.0, 14, 8.0, "Gram", "Hindi, et ve deri", null, 20.399999999999999 },
                    { 157, 371.0, 0.0, 14, 33.600000000000001, "Gram", "Kaz", null, 15.9 },
                    { 158, 404.0, 0.0, 14, 39.299999999999997, "Gram", "Ördek", null, 11.5 },
                    { 159, 75.0, 9.0, 14, 2.0, "Portion", "Şehr. tavuk çorbası", null, 4.0 },
                    { 160, 215.0, 0.0, 14, 15.1, "Gram", "Tavuk Whole", null, 18.600000000000001 },
                    { 161, 186.0, 0.0, 14, 11.1, "Gram", "Tavuk beyaz et (derili)", null, 20.300000000000001 },
                    { 162, 114.0, 0.0, 14, 1.7, "Gram", "Tavuk beyaz et (derisiz)", null, 23.199999999999999 },
                    { 163, 365.0, 13.0, 14, 18.0, "Portion", "Tavuk göğüs kızarmış", null, 35.0 },
                    { 164, 125.0, 0.0, 14, 4.2999999999999998, "Gram", "Tavuk siyah et derisiz", null, 20.100000000000001 },
                    { 165, 349.0, 0.0, 14, 32.399999999999999, "Gram", "Tavuk, deri", null, 13.300000000000001 },
                    { 166, 237.0, 0.0, 14, 18.300000000000001, "Gram", "Tavuk, siyah et (derili)", null, 16.699999999999999 },
                    { 167, 57.0, 13.6, 15, 0.5, "Gram", "Ahududu (Kırmızı)", null, 1.2 },
                    { 168, 73.0, 15.699999999999999, 15, 1.3999999999999999, "Gram", "Ahududu (Siyah)", null, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 169, 52.0, 13.6, 15, 0.20000000000000001, "Gram", "Ananas", null, 0.40000000000000002 },
                    { 170, 61.0, 15.300000000000001, 15, 0.40000000000000002, "Gram", "Armut", null, 0.69999999999999996 },
                    { 171, 167.0, 6.2999999999999998, 15, 16.399999999999999, "Gram", "Avokado", null, 2.1000000000000001 },
                    { 172, 57.0, 15.300000000000001, 15, 0.10000000000000001, "Gram", "Ayva", null, 0.40000000000000002 },
                    { 173, 58.0, 12.9, 15, 0.90000000000000002, "Gram", "Böğürtlen", null, 1.2 },
                    { 174, 37.0, 8.4000000000000004, 15, 0.5, "Gram", "Çilek", null, 0.69999999999999996 },
                    { 175, 93.0, 19.800000000000001, 15, 1.1000000000000001, "Gram", "Dut", null, 0.90000000000000002 },
                    { 176, 58.0, 14.5, 15, 0.59999999999999998, "Gram", "Elma", null, 0.20000000000000001 },
                    { 177, 47.0, 12.0, 15, 0.0, "Gram", "Elma Suyu", null, 0.10000000000000001 },
                    { 178, 66.0, 17.800000000000001, 15, 0.0, "Gram", "Erik (Kırmızı)", null, 0.5 },
                    { 179, 79.0, 19.699999999999999, 15, 0.20000000000000001, "Gram", "Erik (Mürdüm)", null, 0.80000000000000004 },
                    { 180, 255.0, 67.400000000000006, 15, 0.59999999999999998, "Gram", "Erik Mürdüm (Kuru)", null, 2.1000000000000001 },
                    { 181, 344.0, 91.299999999999997, 15, 0.5, "Gram", "Erik Pestil", null, 3.2999999999999998 },
                    { 182, 41.0, 10.6, 15, 0.10000000000000001, "Gram", "Grameyfurt", null, 0.5 },
                    { 183, 39.0, 9.1999999999999993, 15, 0.10000000000000001, "Gram", "Grameyfurt Suyu", null, 0.5 },
                    { 184, 274.0, 72.900000000000006, 15, 0.5, "Gram", "Hurma", null, 2.2000000000000002 },
                    { 185, 15.0, 0.0, 15, 0.0, "Piece", "Hurma", null, 0.0 },
                    { 186, 274.0, 69.099999999999994, 15, 1.3, "Gram", "İncir (Kuru)", null, 4.2999999999999998 },
                    { 187, 80.0, 20.399999999999999, 15, 0.40000000000000002, "Gram", "İncir (Taze)", null, 1.2 },
                    { 188, 26.0, 6.4000000000000004, 15, 0.20000000000000001, "Gram", "Karpuz", null, 0.5 },
                    { 189, 33.0, 7.7000000000000002, 15, 0.29999999999999999, "Gram", "Kavun", null, 0.80000000000000004 },
                    { 190, 260.0, 66.5, 15, 0.5, "Gram", "Kayısı (Kuru)", null, 5.0 },
                    { 191, 17.0, 4.2999999999999998, 15, 0.10000000000000001, "Piece", "Kayısı (Taze)", null, 0.29999999999999999 },
                    { 192, 332.0, 84.599999999999994, 15, 1.0, "Gram", "Kayısı Pestil", null, 5.5999999999999996 },
                    { 193, 5.0, 1.1000000000000001, 15, 0.10000000000000001, "Piece", "Kiraz", null, 0.10000000000000001 },
                    { 194, 30.0, 10.0, 15, 0.10000000000000001, "Gram", "Kivi", null, 0.29999999999999999 },
                    { 195, 27.0, 8.1999999999999993, 15, 0.29999999999999999, "Gram", "Limon", null, 1.1000000000000001 },
                    { 196, 25.0, 8.0, 15, 0.20000000000000001, "Gram", "Limon Suyu", null, 0.5 },
                    { 197, 46.0, 11.6, 15, 0.20000000000000001, "Gram", "Mandalina", null, 0.80000000000000004 },
                    { 198, 43.0, 10.0, 15, 0.20000000000000001, "Gram", "Mandalina Suyu", null, 0.5 },
                    { 199, 105.0, 27.0, 15, 1.0, "Gram", "Muz", null, 1.0 },
                    { 200, 63.0, 16.0, 15, 0.29999999999999999, "Gram", "Nar", null, 0.5 },
                    { 201, 49.0, 12.199999999999999, 15, 0.20000000000000001, "Gram", "Portakal", null, 1.0 },
                    { 202, 38.0, 9.6999999999999993, 15, 0.10000000000000001, "Gram", "Şeftali", null, 0.59999999999999998 },
                    { 203, 289.0, 77.400000000000006, 15, 0.20000000000000001, "Gram", "Üzüm (Kuru)", null, 2.5 },
                    { 204, 67.0, 17.300000000000001, 15, 0.29999999999999999, "Gram", "Üzüm (Taze)", null, 0.59999999999999998 },
                    { 205, 66.0, 16.600000000000001, 15, 0.0, "Gram", "Üzüm Suyu", null, 0.20000000000000001 },
                    { 206, 58.0, 14.300000000000001, 15, 0.29999999999999999, "Gram", "Vişne", null, 1.2 },
                    { 207, 235.0, 0.80000000000000004, 16, 18.199999999999999, "Gram", "Bey. peynir (Edirne)", null, 15.4 },
                    { 208, 312.0, 0.20000000000000001, 16, 26.5, "Gram", "Bey. peynir (Urfa)", null, 15.199999999999999 },
                    { 209, 289.0, 0.0, 16, 21.600000000000001, "Gram", "Bey. peynir (yağlı)", null, 22.5 },
                    { 210, 99.0, 3.7999999999999998, 16, 0.69999999999999996, "Gram", "Bey.peynir (yağsız)", null, 19.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 211, 403.0, 1.3, 16, 33.100000000000001, "Gram", "Cheddar", null, 24.899999999999999 },
                    { 212, 379.0, 13.800000000000001, 16, 11.699999999999999, "Gram", "Çökelek (Kuru)", null, 54.899999999999999 },
                    { 213, 215.0, 3.2000000000000002, 16, 5.5999999999999996, "Gram", "Çökelek (Taze)", null, 35.0 },
                    { 214, 413.0, 0.40000000000000002, 16, 32.299999999999997, "Gram", "Gramavyer (%8 Tuzlu)", null, 29.800000000000001 },
                    { 215, 357.0, 1.3999999999999999, 16, 27.800000000000001, "Gram", "Kars Tipi", null, 25.0 },
                    { 216, 404.0, 1.3999999999999999, 16, 31.699999999999999, "Gram", "Kaşar Peyniri", null, 27.0 },
                    { 217, 349.0, 2.7000000000000002, 16, 34.899999999999999, "Gram", "Krem Peynir (Sade)", null, 7.5999999999999996 },
                    { 218, 72.0, 2.7000000000000002, 16, 1.0, "Gram", "Lor peyniri (%1 yağ)", null, 12.4 },
                    { 219, 90.0, 3.6000000000000001, 16, 1.8999999999999999, "Gram", "Lor peyniri (%2 yağ)", null, 13.699999999999999 },
                    { 220, 85.0, 1.8999999999999999, 16, 0.40000000000000002, "Gram", "Lor peyniri (yağsız)", null, 17.300000000000001 },
                    { 221, 327.0, 0.5, 16, 27.300000000000001, "Gram", "Otlu Peynir", null, 20.100000000000001 },
                    { 222, 369.0, 2.0, 16, 30.600000000000001, "Gram", "Rokfor", null, 21.5 },
                    { 223, 106.0, 0.0, 17, 3.7999999999999998, "Gram", "Akciğer (dana)", null, 16.800000000000001 },
                    { 224, 125.0, 0.80000000000000004, 17, 8.5999999999999996, "Gram", "Beyin", null, 10.4 },
                    { 225, 105.0, 0.90000000000000002, 17, 3.2999999999999998, "Gram", "Böbrek (kuzu)", null, 16.800000000000001 },
                    { 226, 104.0, 0.0, 17, 3.0, "Gram", "Dalak (sığır, dana)", null, 18.100000000000001 },
                    { 227, 130.0, 0.90000000000000002, 17, 5.2999999999999998, "Gram", "Dil (dana)", null, 18.5 },
                    { 228, 100.0, 0.0, 17, 2.0, "Gram", "İşkembe (sığır)", null, 19.100000000000001 },
                    { 229, 140.0, 4.0999999999999996, 17, 4.7000000000000002, "Gram", "Karaciğer (dana)", null, 19.199999999999999 },
                    { 230, 129.0, 2.8999999999999999, 17, 3.7000000000000002, "Gram", "Karaciğer (tavuk)", null, 19.699999999999999 },
                    { 231, 124.0, 1.8, 17, 5.9000000000000004, "Gram", "Yürek (dana)", null, 15.0 },
                    { 232, 97.0, 15.6, 18, 1.1000000000000001, "Gram", "Asma Yaprağı", null, 3.7999999999999998 },
                    { 233, 266.0, 56.100000000000001, 18, 2.2000000000000002, "Gram", "Bamya (Kurutulmuş)", null, 17.399999999999999 },
                    { 234, 36.0, 7.5999999999999996, 18, 0.29999999999999999, "Gram", "Bamya (taze)", null, 2.3999999999999999 },
                    { 235, 84.0, 14.4, 18, 0.40000000000000002, "Gram", "Bezelye (İç)", null, 6.2999999999999998 },
                    { 236, 88.0, 16.800000000000001, 18, 0.40000000000000002, "Gram", "Bezelye (Konserve)", null, 4.7000000000000002 },
                    { 237, 293.0, 64.0, 18, 2.6000000000000001, "Gram", "Biber (Kurutulmuş)", null, 16.0 },
                    { 238, 22.0, 4.7999999999999998, 18, 0.20000000000000001, "Gram", "Biber (Taze)", null, 1.2 },
                    { 239, 127.0, 21.800000000000001, 18, 0.80000000000000004, "Gram", "Börülce (Taze)", null, 9.0 },
                    { 240, 40.0, 8.0, 18, 1.0, "Head", "Brokoli", null, 4.0 },
                    { 241, 25.0, 5.0, 18, 0.20000000000000001, "Gram", "Domates (Kırmızı)", null, 1.0 },
                    { 242, 24.0, 5.0999999999999996, 18, 0.20000000000000001, "Gram", "Domates (Yeşil)", null, 1.2 },
                    { 243, 19.0, 4.2999999999999998, 18, 0.10000000000000001, "Gram", "Domates suyu", null, 0.80000000000000004 },
                    { 244, 47.0, 4.2999999999999998, 18, 0.59999999999999998, "Gram", "Ebegümeci", null, 4.4000000000000004 },
                    { 245, 53.0, 7.7999999999999998, 18, 0.20000000000000001, "Gram", "Enginar", null, 3.0 },
                    { 246, 274.0, 61.100000000000001, 18, 1.7, "Gram", "Fasulye (Kurutulmuş)", null, 8.5999999999999996 },
                    { 247, 32.0, 7.0999999999999996, 18, 0.20000000000000001, "Gram", "Fasulye (Taze)", null, 1.8999999999999999 },
                    { 248, 42.0, 9.6999999999999993, 18, 0.20000000000000001, "Gram", "Havuç", null, 1.1000000000000001 },
                    { 249, 15.0, 3.3999999999999999, 18, 0.10000000000000001, "Gram", "Hıyar (Soyulmamış)", null, 0.90000000000000002 },
                    { 250, 14.0, 3.2000000000000002, 18, 0.10000000000000001, "Gram", "Hıyar (soyulmuş)", null, 0.59999999999999998 },
                    { 251, 53.0, 7.0999999999999996, 18, 0.69999999999999996, "Gram", "Hindibağ Otu", null, 2.7000000000000002 },
                    { 252, 26.0, 4.2999999999999998, 18, 0.29999999999999999, "Gram", "Ispanak", null, 3.2000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 253, 26.0, 6.5, 18, 0.10000000000000001, "Gram", "Kabak (Kış)", null, 1.0 },
                    { 254, 19.0, 4.2000000000000002, 18, 0.10000000000000001, "Gram", "Kabak (Yaz)", null, 11.0 },
                    { 255, 27.0, 5.2000000000000002, 18, 0.20000000000000001, "Gram", "Karnıbahar", null, 2.7000000000000002 },
                    { 256, 40.0, 8.5, 18, 0.29999999999999999, "Gram", "Kereviz", null, 1.8 },
                    { 257, 93.0, 18.100000000000001, 18, 2.2999999999999998, "Gram", "Kırmızı Biber (Taze)", null, 3.7000000000000002 },
                    { 258, 20.0, 4.0999999999999996, 18, 0.10000000000000001, "Gram", "Kıvırcık", null, 1.7 },
                    { 259, 24.0, 5.2000000000000002, 18, 0.20000000000000001, "Gram", "Konserve fasulye", null, 1.3999999999999999 },
                    { 260, 26.0, 5.0, 18, 0.20000000000000001, "Gram", "Kuşkonmaz", null, 2.5 },
                    { 261, 24.0, 5.4000000000000004, 18, 0.20000000000000001, "Gram", "Lahana (Beyaz)", null, 1.3 },
                    { 262, 63.0, 8.0, 18, 0.29999999999999999, "Gram", "Lahana (Brüksel)", null, 5.2000000000000002 },
                    { 263, 45.0, 5.0, 18, 0.29999999999999999, "Gram", "Lahana (Kara)", null, 4.0 },
                    { 264, 31.0, 6.9000000000000004, 18, 0.20000000000000001, "Gram", "Lahana (Kırmızı)", null, 2.0 },
                    { 265, 22.0, 0.0, 18, 0.29999999999999999, "Gram", "Madımak", null, 2.3999999999999999 },
                    { 266, 28.0, 4.4000000000000004, 18, 0.29999999999999999, "Gram", "Mantar", null, 2.7000000000000002 },
                    { 267, 14.0, 2.5, 18, 0.20000000000000001, "Gram", "Marul", null, 1.2 },
                    { 268, 44.0, 8.5, 18, 0.59999999999999998, "Gram", "Maydonoz", null, 3.6000000000000001 },
                    { 269, 96.0, 22.100000000000001, 18, 1.0, "Gram", "Mısır (Taze)", null, 3.5 },
                    { 270, 65.0, 7.9000000000000004, 18, 1.3, "Gram", "Nane (Taze)", null, 4.0 },
                    { 271, 43.0, 9.9000000000000004, 18, 0.10000000000000001, "Gram", "Pancar (Kırmızı)", null, 1.6000000000000001 },
                    { 272, 24.0, 4.5999999999999996, 18, 0.29999999999999999, "Gram", "Pancar (Yaprak)", null, 2.2000000000000002 },
                    { 273, 76.0, 17.100000000000001, 18, 0.10000000000000001, "Gram", "Patates", null, 2.1000000000000001 },
                    { 274, 351.0, 80.0, 18, 0.80000000000000004, "Gram", "Patates unu", null, 8.0 },
                    { 275, 286.0, 49.0, 18, 2.2999999999999998, "Gram", "Patlıcan (kurutul.)", null, 13.699999999999999 },
                    { 276, 25.0, 5.5999999999999996, 18, 0.20000000000000001, "Gram", "Patlıcan (Taze)", null, 1.2 },
                    { 277, 33.0, 4.2000000000000002, 18, 0.29999999999999999, "Gram", "Pazı", null, 2.0 },
                    { 278, 52.0, 11.199999999999999, 18, 0.29999999999999999, "Gram", "Pırasa", null, 2.2000000000000002 },
                    { 279, 33.0, 3.2000000000000002, 18, 0.59999999999999998, "Gram", "Roka", null, 3.0 },
                    { 280, 137.0, 30.800000000000001, 18, 0.20000000000000001, "Gram", "Sarmısak (Head)", null, 6.2000000000000002 },
                    { 281, 332.0, 72.700000000000003, 18, 0.80000000000000004, "Gram", "Sarmısak (Toz)", null, 16.800000000000001 },
                    { 282, 32.0, 3.7999999999999998, 18, 0.40000000000000002, "Gram", "Semiz Otu", null, 2.0 },
                    { 283, 38.0, 8.6999999999999993, 18, 0.10000000000000001, "Gram", "Soğan (Kuru)", null, 1.5 },
                    { 284, 347.0, 80.700000000000003, 18, 1.1000000000000001, "Gram", "Soğan (Toz)", null, 10.1 },
                    { 285, 36.0, 8.1999999999999993, 18, 0.20000000000000001, "Gram", "Soğan (Yeşil)", null, 1.5 },
                    { 286, 30.0, 6.5999999999999996, 18, 0.20000000000000001, "Gram", "Şalgam", null, 1.0 },
                    { 287, 72.0, 9.8000000000000007, 18, 0.40000000000000002, "Gram", "Taze Bakla", null, 5.2000000000000002 },
                    { 288, 33.0, 6.0, 18, 1.0, "Gram", "Tere", null, 3.0 },
                    { 289, 19.0, 4.2000000000000002, 18, 0.10000000000000001, "Gram", "Turp (Kırmızı)", null, 0.90000000000000002 },
                    { 290, 30.0, 6.5999999999999996, 18, 0.20000000000000001, "Gram", "Turp (Siyah)", null, 1.0 },
                    { 291, 75.0, 16.699999999999999, 18, 0.10000000000000001, "Gram", "Yer Elması", null, 2.2999999999999998 },
                    { 292, 49.0, 9.0, 18, 0.59999999999999998, "Gram", "Yonca", null, 1.0 },
                    { 293, 377.0, 15.199999999999999, 19, 35.700000000000003, "Gram", "Bin Ada Yağı", null, 0.90000000000000002 },
                    { 294, 430.0, 17.5, 19, 41.0, "Gram", "Fransız salata sosu", null, 0.59999999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 295, 467.0, 10.199999999999999, 19, 48.299999999999997, "Gram", "İtalyan salata sosu", null, 0.69999999999999996 },
                    { 296, 106.0, 25.399999999999999, 19, 0.40000000000000002, "Gram", "Ketçap", null, 2.0 },
                    { 297, 340.0, 31.0, 19, 16.0, "Glass", "Kıymalı Chili", null, 19.0 },
                    { 298, 134.0, 4.5999999999999996, 19, 11.699999999999999, "Gram", "Krema (%50 yağ, süt)", null, 3.2000000000000002 },
                    { 299, 390.0, 23.899999999999999, 19, 33.399999999999999, "Gram", "Mayonez", null, 0.90000000000000002 },
                    { 300, 449.0, 2.5, 19, 50.100000000000001, "Gram", "Salata sosu (yağlı)", null, 0.0 },
                    { 301, 98.0, 21.300000000000001, 19, 0.40000000000000002, "Gram", "Salça", null, 2.7000000000000002 },
                    { 302, 68.0, 9.5, 19, 1.3, "Gram", "Soya Sosu", null, 5.5999999999999996 },
                    { 303, 70.0, 6.9000000000000004, 20, 4.4000000000000004, "Gram", "Anne sütü", null, 1.0 },
                    { 304, 50.0, 4.7999999999999998, 20, 1.8999999999999999, "Gram", "İnek (1/2 yağlı)", null, 3.2999999999999998 },
                    { 305, 61.0, 4.7000000000000002, 20, 3.2999999999999998, "Gram", "İnek (Yağlı)", null, 3.2999999999999998 },
                    { 306, 35.0, 4.9000000000000004, 20, 0.20000000000000001, "Gram", "İnek (yağsız)", null, 3.3999999999999999 },
                    { 307, 69.0, 4.5, 20, 4.0999999999999996, "Gram", "Keçi sütü", null, 3.6000000000000001 },
                    { 308, 108.0, 5.4000000000000004, 20, 7.0, "Gram", "Koyun", null, 6.0 },
                    { 309, 97.0, 5.2000000000000002, 20, 6.9000000000000004, "Gram", "Manda sütü", null, 3.7999999999999998 },
                    { 310, 33.0, 2.2000000000000002, 20, 1.5, "Gram", "Soya", null, 3.3999999999999999 },
                    { 311, 496.0, 38.399999999999999, 20, 26.699999999999999, "Gram", "Süt Tozu (Yağlı)", null, 26.300000000000001 },
                    { 312, 362.0, 52.0, 20, 0.80000000000000004, "Gram", "Süt Tozu (Yağsız)", null, 36.200000000000003 },
                    { 313, 50.0, 5.2000000000000002, 20, 1.7, "Gram", "Yoğurt (1/2 yağlı)", null, 3.3999999999999999 },
                    { 314, 62.0, 4.9000000000000004, 20, 3.3999999999999999, "Gram", "Yoğurt (Yağlı)", null, 3.0 },
                    { 315, 330.0, 86.900000000000006, 21, 0.0, "Gram", "Akide şekeri", null, 0.0 },
                    { 316, 315.0, 78.400000000000006, 21, 0.0, "Gram", "Bal", null, 0.29999999999999999 },
                    { 317, 418.0, 85.400000000000006, 21, 7.9000000000000004, "Gram", "Bisküvi", null, 6.5999999999999996 },
                    { 318, 462.0, 74.400000000000006, 21, 16.100000000000001, "Gram", "Bisküvi (pasta)", null, 5.4000000000000004 },
                    { 319, 532.0, 51.299999999999997, 21, 35.600000000000001, "Gram", "Çikolata (Bademli)", null, 9.3000000000000007 },
                    { 320, 543.0, 44.600000000000001, 21, 38.100000000000001, "Gram", "Çikolata (Fıstıklı)", null, 14.1 },
                    { 321, 528.0, 57.899999999999999, 21, 35.100000000000001, "Gram", "Çikolata (Şekerli)", null, 4.4000000000000004 },
                    { 322, 477.0, 46.799999999999997, 21, 39.700000000000003, "Gram", "Çikolata (Şekersiz)", null, 7.9000000000000004 },
                    { 323, 193.0, 20.800000000000001, 21, 10.6, "Gram", "Dondurma (Sütlü)", null, 4.5 },
                    { 324, 399.0, 76.599999999999994, 21, 10.199999999999999, "Gram", "Karamela", null, 4.0 },
                    { 325, 240.0, 57.0, 21, 1.0, "Gram", "Lokum", null, 0.0 },
                    { 326, 278.0, 70.799999999999997, 21, 0.29999999999999999, "Gram", "Marmelat", null, 0.5 },
                    { 327, 316.0, 80.599999999999994, 21, 0.29999999999999999, "Gram", "Meyva şekerleme", null, 0.40000000000000002 },
                    { 328, 293.0, 70.599999999999994, 21, 0.10000000000000001, "Gram", "Pekmez (Üzüm)", null, 0.59999999999999998 },
                    { 329, 272.0, 70.0, 21, 0.10000000000000001, "Gram", "Reçel", null, 0.59999999999999998 },
                    { 330, 385.0, 99.5, 21, 0.0, "Gram", "Şeker", null, 0.0 },
                    { 331, 516.0, 53.5, 21, 28.0, "Gram", "Tahin helvası", null, 10.5 },
                    { 332, 349.0, 78.799999999999997, 22, 1.0, "Gram", "Arpa", null, 8.1999999999999993 },
                    { 333, 335.0, 72.900000000000006, 22, 2.5, "Gram", "Buğday (aşurelik)", null, 11.0 },
                    { 334, 332.0, 70.099999999999994, 22, 2.5, "Gram", "Buğday (durum)", null, 12.699999999999999 },
                    { 335, 357.0, 78.099999999999994, 22, 1.2, "Gram", "Bulgur", null, 10.1 },
                    { 336, 386.0, 85.299999999999997, 22, 0.40000000000000002, "Gram", "Corn Flakes", null, 7.9000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 337, 350.0, 74.799999999999997, 22, 1.7, "Gram", "Çavdar Unu", null, 3.1000000000000001 },
                    { 338, 90.0, 0.0, 22, 0.0, "Slice", "Ekmek (beyaz)", null, 0.0 },
                    { 339, 365.0, 74.700000000000003, 22, 1.1000000000000001, "Gram", "Ekmeklik", null, 11.800000000000001 },
                    { 340, 213.0, 61.899999999999999, 22, 4.5999999999999996, "Gram", "Kepek", null, 16.0 },
                    { 341, 91.0, 21.0, 22, 1.0, "Gram", "Mısır (haşlan.)", null, 3.2999999999999998 },
                    { 342, 368.0, 76.900000000000006, 22, 2.6000000000000001, "Gram", "Mısır unu", null, 7.7999999999999998 },
                    { 343, 362.0, 72.099999999999994, 22, 4.7000000000000002, "Gram", "Mısır, tane", null, 11.9 },
                    { 344, 362.0, 87.599999999999994, 22, 0.0, "Gram", "Nişasta", null, 0.29999999999999999 },
                    { 345, 456.0, 59.100000000000001, 22, 21.800000000000001, "Gram", "Patlamış mısır", null, 9.8000000000000007 },
                    { 346, 363.0, 80.400000000000006, 22, 0.40000000000000002, "Gram", "Pirinç", null, 6.7000000000000002 },
                    { 347, 388.0, 72.0, 22, 4.5999999999999996, "Gram", "Şehriye", null, 12.800000000000001 },
                    { 348, 316.0, 56.399999999999999, 22, 4.4000000000000004, "Gram", "Tarhana", null, 12.199999999999999 },
                    { 349, 388.0, 68.0, 22, 75.0, "Gram", "Yulaf Unu", null, 12.0 },
                    { 350, 280.0, 26.0, 23, 18.0, "Slice", "Cheesecake", null, 5.0 },
                    { 351, 3350.0, 317.0, 23, 213.0, "Whole", "Cheesecake", null, 60.0 },
                    { 352, 45.0, 7.0, 23, 2.0, "Piece", "Çikolatalı kurabiye", null, 0.5 },
                    { 353, 405.0, 60.0, 23, 18.0, "Slice", "Elmalı turta", null, 3.0 },
                    { 354, 2420.0, 360.0, 23, 105.0, "Whole", "Elmalı turta", null, 21.0 },
                    { 355, 211.0, 33.200000000000003, 23, 7.5999999999999996, "Gram", "Hanımgöbeği", null, 2.3999999999999999 },
                    { 356, 6175.0, 775.0, 23, 328.0, "Whole", "Havuçlu kek", null, 63.0 },
                    { 357, 385.0, 48.0, 23, 21.0, "Slice", "Havuçlu kek", null, 4.0 },
                    { 358, 318.0, 59.399999999999999, 23, 7.0999999999999996, "Gram", "Hurma tatlısı", null, 4.0999999999999996 },
                    { 359, 302.0, 43.600000000000001, 23, 12.5, "Gram", "İrmik helvası", null, 3.7999999999999998 },
                    { 360, 259.0, 62.5, 23, 0.0, "Gram", "Jöle", null, 6.0999999999999996 },
                    { 361, 126.0, 16.100000000000001, 23, 5.2000000000000002, "Gram", "Kastırd", null, 5.9000000000000004 },
                    { 362, 364.0, 79.400000000000006, 23, 0.80000000000000004, "Gram", "Kek pasta", null, 7.5 },
                    { 363, 173.0, 29.699999999999999, 23, 3.7999999999999998, "Gram", "Muhallebi", null, 5.0999999999999996 },
                    { 364, 139.0, 38.0, 23, 2.7000000000000002, "Gram", "Sütlaç", null, 3.3999999999999999 },
                    { 365, 286.0, 46.700000000000003, 23, 9.0999999999999996, "Gram", "Tel kadayıf (fıstıklı)", null, 4.2999999999999998 },
                    { 366, 535.0, 62.5, 23, 21.899999999999999, "Gram", "Wafers", null, 4.7000000000000002 },
                    { 367, 158.0, 0.40000000000000002, 24, 11.1, "Gram", "Bıldırcın yumurta", null, 13.1 },
                    { 368, 185.0, 1.3999999999999999, 24, 13.300000000000001, "Gram", "Kaz yumurta", null, 13.9 },
                    { 369, 185.0, 1.5, 24, 13.800000000000001, "Gram", "Ördek yumurta", null, 12.800000000000001 },
                    { 370, 49.0, 1.2, 24, 0.0, "Gram", "Tavuk yumurta (beyaz)", null, 10.1 },
                    { 371, 369.0, 0.20000000000000001, 24, 32.899999999999999, "Gram", "Tavuk yumurta (sarı)", null, 16.399999999999999 },
                    { 372, 158.0, 1.2, 24, 11.199999999999999, "Gram", "Tavuk yumurta (tam)", null, 12.1 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "CustomerId", "EatDay", "MealCalorie", "MealCarbohydrate", "MealFat", "MealProtein", "Name" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 31, 20, 27, 11, 401, DateTimeKind.Local).AddTicks(5742), 500.0, 200.0, 50.0, 100.0, "Breakfast" });

            migrationBuilder.InsertData(
                table: "MealDetails",
                columns: new[] { "FoodID", "MealID", "Quantity" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetails_FoodID",
                table: "MealDetails",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CustomerId",
                table: "Meals",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealDetails");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
