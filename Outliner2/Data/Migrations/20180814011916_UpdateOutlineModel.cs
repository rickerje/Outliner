using Microsoft.EntityFrameworkCore.Migrations;

namespace Outliner.Data.Migrations
{
    public partial class UpdateOutlineModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentUserId",
                table: "Outlines",
                newName: "CurrentUserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentUserName",
                table: "Outlines",
                newName: "CurrentUserId");
        }
    }
}
