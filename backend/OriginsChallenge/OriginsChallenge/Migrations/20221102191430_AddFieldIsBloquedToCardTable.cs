using Microsoft.EntityFrameworkCore.Migrations;

namespace OriginsChallenge.Migrations
{
    public partial class AddFieldIsBloquedToCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBloqued",
                table: "Card",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBloqued",
                table: "Card");
        }
    }
}
