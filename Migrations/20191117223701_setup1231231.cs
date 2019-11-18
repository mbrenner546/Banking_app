using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_team12.Migrations
{
    public partial class setup1231231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AspNetUsers_AppUserId",
                table: "BankAccounts");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "BankAccounts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_AppUserId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AspNetUsers_UserId",
                table: "BankAccounts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AspNetUsers_UserId",
                table: "BankAccounts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BankAccounts",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_UserId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AspNetUsers_AppUserId",
                table: "BankAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
