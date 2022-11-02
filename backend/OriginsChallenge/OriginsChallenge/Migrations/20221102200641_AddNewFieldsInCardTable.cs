using Microsoft.EntityFrameworkCore.Migrations;

namespace OriginsChallenge.Migrations
{
    public partial class AddNewFieldsInCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBloqued",
                table: "Card");

            migrationBuilder.AddColumn<int>(
                name: "FailedAttempts",
                table: "Card",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Card",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Pin",
                table: "Card",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FailedAttempts",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Card");

            migrationBuilder.AddColumn<bool>(
                name: "IsBloqued",
                table: "Card",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
