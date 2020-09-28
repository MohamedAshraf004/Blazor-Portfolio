using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlazor.Data.Migrations
{
    public partial class ModifySocialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Social_PortfolioUsers_UserId",
                table: "Social");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Social",
                table: "Social");

            migrationBuilder.RenameTable(
                name: "Social",
                newName: "Socials");

            migrationBuilder.RenameIndex(
                name: "IX_Social_UserId",
                table: "Socials",
                newName: "IX_Socials_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Socials",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socials",
                table: "Socials",
                column: "SocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_PortfolioUsers_UserId",
                table: "Socials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socials",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Socials");

            migrationBuilder.RenameTable(
                name: "Socials",
                newName: "Social");

            migrationBuilder.RenameIndex(
                name: "IX_Socials_UserId",
                table: "Social",
                newName: "IX_Social_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Social",
                table: "Social",
                column: "SocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Social_PortfolioUsers_UserId",
                table: "Social",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
