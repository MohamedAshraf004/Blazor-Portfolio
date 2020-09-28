using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlazor.Data.Migrations
{
    public partial class ModifyInternshipTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Internships",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Internships");
        }
    }
}
