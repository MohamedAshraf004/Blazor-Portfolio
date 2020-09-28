using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlazor.Data.Migrations
{
    public partial class ModifySocialTableAddForeginKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Socials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Socials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
