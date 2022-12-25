using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftECommerece.Data.Migrations
{
    public partial class FirstMigrationToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "tbl_Foundation_UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "tbl_Foundation_UserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "tbl_Foundation_UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "tbl_Foundation_UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "tbl_Foundation_Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "tbl_Foundation_RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "tbl_Foundation_UserRoles",
                newName: "IX_tbl_Foundation_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "tbl_Foundation_UserLogins",
                newName: "IX_tbl_Foundation_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "tbl_Foundation_UserClaims",
                newName: "IX_tbl_Foundation_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "tbl_Foundation_RoleClaims",
                newName: "IX_tbl_Foundation_RoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Foundation_UserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "tbl_Foundation_UserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "tbl_Foundation_UserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "tbl_Foundation_UserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_UserTokens",
                table: "tbl_Foundation_UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_UserRoles",
                table: "tbl_Foundation_UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_UserLogins",
                table: "tbl_Foundation_UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_UserClaims",
                table: "tbl_Foundation_UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_Roles",
                table: "tbl_Foundation_Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Foundation_RoleClaims",
                table: "tbl_Foundation_RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tbl_Foundation_Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Foundation_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tbl_Foundation_Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tbl_Foundation_Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_RoleClaims_tbl_Foundation_Roles_RoleId",
                table: "tbl_Foundation_RoleClaims",
                column: "RoleId",
                principalTable: "tbl_Foundation_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_UserClaims_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserClaims",
                column: "UserId",
                principalTable: "tbl_Foundation_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_UserLogins_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserLogins",
                column: "UserId",
                principalTable: "tbl_Foundation_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_UserRoles_tbl_Foundation_Roles_RoleId",
                table: "tbl_Foundation_UserRoles",
                column: "RoleId",
                principalTable: "tbl_Foundation_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_UserRoles_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserRoles",
                column: "UserId",
                principalTable: "tbl_Foundation_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Foundation_UserTokens_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserTokens",
                column: "UserId",
                principalTable: "tbl_Foundation_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_RoleClaims_tbl_Foundation_Roles_RoleId",
                table: "tbl_Foundation_RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_UserClaims_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_UserLogins_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_UserRoles_tbl_Foundation_Roles_RoleId",
                table: "tbl_Foundation_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_UserRoles_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Foundation_UserTokens_tbl_Foundation_Users_UserId",
                table: "tbl_Foundation_UserTokens");

            migrationBuilder.DropTable(
                name: "tbl_Foundation_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_UserTokens",
                table: "tbl_Foundation_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_UserRoles",
                table: "tbl_Foundation_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_UserLogins",
                table: "tbl_Foundation_UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_UserClaims",
                table: "tbl_Foundation_UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_Roles",
                table: "tbl_Foundation_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Foundation_RoleClaims",
                table: "tbl_Foundation_RoleClaims");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_UserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "tbl_Foundation_RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Foundation_UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Foundation_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Foundation_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Foundation_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
