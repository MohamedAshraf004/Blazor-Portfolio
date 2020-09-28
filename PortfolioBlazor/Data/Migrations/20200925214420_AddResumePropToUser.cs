using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlazor.Data.Migrations
{
    public partial class AddResumePropToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resume",
                table: "PortfolioUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resume",
                table: "PortfolioUsers");
        }
    }
}
