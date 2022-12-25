using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftECommerece.Data.Migrations
{
    public partial class AddPrimaryKeyToUserRolesTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblFoundationRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblFoundationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblFoundationRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFoundationRoleClaims_TblFoundationRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "TblFoundationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblFoundationUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFoundationUserClaims_TblFoundationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TblFoundationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblFoundationUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFoundationUserRoles_TblFoundationRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "TblFoundationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblFoundationUserRoles_TblFoundationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TblFoundationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblFoundationUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    UserId1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFoundationUserTokens", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_TblFoundationUserTokens_TblFoundationUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "TblFoundationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblFoundationRoleClaims_RoleId",
                table: "TblFoundationRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFoundationUserClaims_UserId",
                table: "TblFoundationUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFoundationUserRoles_RoleId",
                table: "TblFoundationUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFoundationUserRoles_UserId",
                table: "TblFoundationUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFoundationUserTokens_UserId1",
                table: "TblFoundationUserTokens",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblFoundationRoleClaims");

            migrationBuilder.DropTable(
                name: "TblFoundationUserClaims");

            migrationBuilder.DropTable(
                name: "TblFoundationUserRoles");

            migrationBuilder.DropTable(
                name: "TblFoundationUserTokens");

            migrationBuilder.DropTable(
                name: "TblFoundationRoles");

            migrationBuilder.DropTable(
                name: "TblFoundationUsers");
        }
    }
}
