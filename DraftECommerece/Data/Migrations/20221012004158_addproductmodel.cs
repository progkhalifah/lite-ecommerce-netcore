using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftECommerece.Data.Migrations
{
    public partial class addproductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Foundation_Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(nullable: false),
                    PriceProduct = table.Column<decimal>(nullable: false),
                    ImageProduct = table.Column<string>(nullable: true),
                    ProductColor = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Foundation_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Foundation_Products_tbl_Foundation_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "tbl_Foundation_ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Foundation_Products_ProductTypeId",
                table: "tbl_Foundation_Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Foundation_Products");
        }
    }
}
