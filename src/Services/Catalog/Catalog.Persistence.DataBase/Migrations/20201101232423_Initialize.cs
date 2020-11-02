using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.DataBase.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 400m },
                    { 73, "Description for product 73", "Product 73", 942m },
                    { 72, "Description for product 72", "Product 72", 843m },
                    { 71, "Description for product 71", "Product 71", 115m },
                    { 70, "Description for product 70", "Product 70", 176m },
                    { 69, "Description for product 69", "Product 69", 208m },
                    { 68, "Description for product 68", "Product 68", 711m },
                    { 67, "Description for product 67", "Product 67", 496m },
                    { 66, "Description for product 66", "Product 66", 257m },
                    { 65, "Description for product 65", "Product 65", 484m },
                    { 64, "Description for product 64", "Product 64", 844m },
                    { 63, "Description for product 63", "Product 63", 781m },
                    { 62, "Description for product 62", "Product 62", 880m },
                    { 61, "Description for product 61", "Product 61", 578m },
                    { 60, "Description for product 60", "Product 60", 181m },
                    { 59, "Description for product 59", "Product 59", 813m },
                    { 58, "Description for product 58", "Product 58", 454m },
                    { 57, "Description for product 57", "Product 57", 216m },
                    { 56, "Description for product 56", "Product 56", 313m },
                    { 55, "Description for product 55", "Product 55", 869m },
                    { 54, "Description for product 54", "Product 54", 741m },
                    { 53, "Description for product 53", "Product 53", 596m },
                    { 74, "Description for product 74", "Product 74", 297m },
                    { 52, "Description for product 52", "Product 52", 982m },
                    { 75, "Description for product 75", "Product 75", 381m },
                    { 77, "Description for product 77", "Product 77", 699m },
                    { 98, "Description for product 98", "Product 98", 641m },
                    { 97, "Description for product 97", "Product 97", 349m },
                    { 96, "Description for product 96", "Product 96", 430m },
                    { 95, "Description for product 95", "Product 95", 762m },
                    { 94, "Description for product 94", "Product 94", 530m },
                    { 93, "Description for product 93", "Product 93", 775m },
                    { 92, "Description for product 92", "Product 92", 280m },
                    { 91, "Description for product 91", "Product 91", 301m },
                    { 90, "Description for product 90", "Product 90", 348m },
                    { 89, "Description for product 89", "Product 89", 427m },
                    { 88, "Description for product 88", "Product 88", 289m },
                    { 87, "Description for product 87", "Product 87", 115m },
                    { 86, "Description for product 86", "Product 86", 918m },
                    { 85, "Description for product 85", "Product 85", 783m },
                    { 84, "Description for product 84", "Product 84", 781m },
                    { 83, "Description for product 83", "Product 83", 697m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 514m },
                    { 81, "Description for product 81", "Product 81", 788m },
                    { 80, "Description for product 80", "Product 80", 867m },
                    { 79, "Description for product 79", "Product 79", 866m },
                    { 78, "Description for product 78", "Product 78", 865m },
                    { 76, "Description for product 76", "Product 76", 136m },
                    { 51, "Description for product 51", "Product 51", 593m },
                    { 50, "Description for product 50", "Product 50", 996m },
                    { 49, "Description for product 49", "Product 49", 817m },
                    { 22, "Description for product 22", "Product 22", 186m },
                    { 21, "Description for product 21", "Product 21", 167m },
                    { 20, "Description for product 20", "Product 20", 592m },
                    { 19, "Description for product 19", "Product 19", 538m },
                    { 18, "Description for product 18", "Product 18", 554m },
                    { 17, "Description for product 17", "Product 17", 432m },
                    { 16, "Description for product 16", "Product 16", 650m },
                    { 15, "Description for product 15", "Product 15", 494m },
                    { 14, "Description for product 14", "Product 14", 670m },
                    { 13, "Description for product 13", "Product 13", 908m },
                    { 12, "Description for product 12", "Product 12", 428m },
                    { 11, "Description for product 11", "Product 11", 769m },
                    { 10, "Description for product 10", "Product 10", 385m },
                    { 9, "Description for product 9", "Product 9", 221m },
                    { 8, "Description for product 8", "Product 8", 558m },
                    { 7, "Description for product 7", "Product 7", 395m },
                    { 6, "Description for product 6", "Product 6", 848m },
                    { 5, "Description for product 5", "Product 5", 525m },
                    { 4, "Description for product 4", "Product 4", 813m },
                    { 3, "Description for product 3", "Product 3", 333m },
                    { 2, "Description for product 2", "Product 2", 117m },
                    { 23, "Description for product 23", "Product 23", 901m },
                    { 24, "Description for product 24", "Product 24", 879m },
                    { 25, "Description for product 25", "Product 25", 999m },
                    { 26, "Description for product 26", "Product 26", 443m },
                    { 48, "Description for product 48", "Product 48", 855m },
                    { 47, "Description for product 47", "Product 47", 655m },
                    { 46, "Description for product 46", "Product 46", 232m },
                    { 45, "Description for product 45", "Product 45", 113m },
                    { 44, "Description for product 44", "Product 44", 135m },
                    { 43, "Description for product 43", "Product 43", 486m },
                    { 42, "Description for product 42", "Product 42", 131m },
                    { 41, "Description for product 41", "Product 41", 310m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 340m },
                    { 39, "Description for product 39", "Product 39", 612m },
                    { 99, "Description for product 99", "Product 99", 650m },
                    { 38, "Description for product 38", "Product 38", 588m },
                    { 36, "Description for product 36", "Product 36", 418m },
                    { 35, "Description for product 35", "Product 35", 562m },
                    { 34, "Description for product 34", "Product 34", 297m },
                    { 33, "Description for product 33", "Product 33", 931m },
                    { 32, "Description for product 32", "Product 32", 612m },
                    { 31, "Description for product 31", "Product 31", 901m },
                    { 30, "Description for product 30", "Product 30", 377m },
                    { 29, "Description for product 29", "Product 29", 777m },
                    { 28, "Description for product 28", "Product 28", 514m },
                    { 27, "Description for product 27", "Product 27", 369m },
                    { 37, "Description for product 37", "Product 37", 635m },
                    { 100, "Description for product 100", "Product 100", 855m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 53 },
                    { 73, 73, 2 },
                    { 72, 72, 30 },
                    { 71, 71, 82 },
                    { 70, 70, 3 },
                    { 69, 69, 94 },
                    { 68, 68, 56 },
                    { 67, 67, 99 },
                    { 66, 66, 13 },
                    { 65, 65, 91 },
                    { 64, 64, 89 },
                    { 63, 63, 90 },
                    { 62, 62, 11 },
                    { 61, 61, 44 },
                    { 60, 60, 64 },
                    { 59, 59, 90 },
                    { 58, 58, 39 },
                    { 57, 57, 4 },
                    { 56, 56, 4 },
                    { 55, 55, 22 },
                    { 54, 54, 64 },
                    { 53, 53, 57 },
                    { 74, 74, 48 },
                    { 52, 52, 57 },
                    { 75, 75, 14 },
                    { 77, 77, 91 },
                    { 98, 98, 67 },
                    { 97, 97, 4 },
                    { 96, 96, 44 },
                    { 95, 95, 55 },
                    { 94, 94, 95 },
                    { 93, 93, 78 },
                    { 92, 92, 79 },
                    { 91, 91, 23 },
                    { 90, 90, 30 },
                    { 89, 89, 33 },
                    { 88, 88, 53 },
                    { 87, 87, 39 },
                    { 86, 86, 68 },
                    { 85, 85, 84 },
                    { 84, 84, 48 },
                    { 83, 83, 21 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 96 },
                    { 81, 81, 21 },
                    { 80, 80, 28 },
                    { 79, 79, 60 },
                    { 78, 78, 0 },
                    { 76, 76, 78 },
                    { 51, 51, 98 },
                    { 50, 50, 57 },
                    { 49, 49, 28 },
                    { 22, 22, 48 },
                    { 21, 21, 73 },
                    { 20, 20, 70 },
                    { 19, 19, 48 },
                    { 18, 18, 62 },
                    { 17, 17, 99 },
                    { 16, 16, 1 },
                    { 15, 15, 32 },
                    { 14, 14, 30 },
                    { 13, 13, 12 },
                    { 12, 12, 16 },
                    { 11, 11, 10 },
                    { 10, 10, 17 },
                    { 9, 9, 72 },
                    { 8, 8, 95 },
                    { 7, 7, 61 },
                    { 6, 6, 75 },
                    { 5, 5, 73 },
                    { 4, 4, 85 },
                    { 3, 3, 43 },
                    { 2, 2, 77 },
                    { 23, 23, 72 },
                    { 24, 24, 4 },
                    { 25, 25, 95 },
                    { 26, 26, 9 },
                    { 48, 48, 34 },
                    { 47, 47, 87 },
                    { 46, 46, 66 },
                    { 45, 45, 44 },
                    { 44, 44, 72 },
                    { 43, 43, 57 },
                    { 42, 42, 94 },
                    { 41, 41, 56 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 99 },
                    { 39, 39, 59 },
                    { 99, 99, 81 },
                    { 38, 38, 68 },
                    { 36, 36, 28 },
                    { 35, 35, 35 },
                    { 34, 34, 56 },
                    { 33, 33, 17 },
                    { 32, 32, 96 },
                    { 31, 31, 25 },
                    { 30, 30, 83 },
                    { 29, 29, 5 },
                    { 28, 28, 49 },
                    { 27, 27, 31 },
                    { 37, 37, 19 },
                    { 100, 100, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
