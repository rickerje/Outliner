using Microsoft.EntityFrameworkCore.Migrations;

namespace Outliner.Data.Migrations
{
    public partial class updateCharacterClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProtagonist",
                table: "Characters",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProtagonist",
                table: "Characters");
        }
    }
}
