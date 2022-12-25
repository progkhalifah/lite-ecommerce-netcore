using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftECommerece.Data.Migrations
{
    public partial class addOrderandOrderDetailsable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Foundation_Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Foundation_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Foundation_OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProdcutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Foundation_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Foundation_OrderDetails_tbl_Foundation_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "tbl_Foundation_Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Foundation_OrderDetails_tbl_Foundation_Products_ProdcutId",
                        column: x => x.ProdcutId,
                        principalTable: "tbl_Foundation_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Foundation_OrderDetails_OrderId",
                table: "tbl_Foundation_OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Foundation_OrderDetails_ProdcutId",
                table: "tbl_Foundation_OrderDetails",
                column: "ProdcutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Foundation_OrderDetails");

            migrationBuilder.DropTable(
                name: "tbl_Foundation_Order");
        }
    }
}
