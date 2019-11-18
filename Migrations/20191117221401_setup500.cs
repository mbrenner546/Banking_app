using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_team12.Migrations
{
    public partial class setup500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "BankAccounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "BankAccounts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
