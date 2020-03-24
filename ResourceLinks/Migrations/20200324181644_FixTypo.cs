using Microsoft.EntityFrameworkCore.Migrations;

namespace ResourceLinks.Migrations
{
    public partial class FixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResourseName",
                table: "Links",
                newName: "ResourceName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResourceName",
                table: "Links",
                newName: "ResourseName");
        }
    }
}
