using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlazor.Data.Migrations
{
    public partial class ModifySkillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_PortfolioUsers_UserId",
                table: "Activites");

            migrationBuilder.DropForeignKey(
                name: "FK_Honors_PortfolioUsers_UserId",
                table: "Honors");

            migrationBuilder.DropForeignKey(
                name: "FK_Internships_PortfolioUsers_UserId",
                table: "Internships");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_PortfolioUsers_UserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PortfolioUsers_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PortfolioUsers_UserId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Skills",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Languages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Internships",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Honors",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Activites",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_PortfolioUsers_UserId",
                table: "Activites",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Honors_PortfolioUsers_UserId",
                table: "Honors",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_PortfolioUsers_UserId",
                table: "Internships",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_PortfolioUsers_UserId",
                table: "Languages",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PortfolioUsers_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PortfolioUsers_UserId",
                table: "Skills",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_PortfolioUsers_UserId",
                table: "Activites");

            migrationBuilder.DropForeignKey(
                name: "FK_Honors_PortfolioUsers_UserId",
                table: "Honors");

            migrationBuilder.DropForeignKey(
                name: "FK_Internships_PortfolioUsers_UserId",
                table: "Internships");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_PortfolioUsers_UserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PortfolioUsers_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PortfolioUsers_UserId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Languages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Internships",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Honors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Activites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_PortfolioUsers_UserId",
                table: "Activites",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Honors_PortfolioUsers_UserId",
                table: "Honors",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_PortfolioUsers_UserId",
                table: "Internships",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_PortfolioUsers_UserId",
                table: "Languages",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PortfolioUsers_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PortfolioUsers_UserId",
                table: "Skills",
                column: "UserId",
                principalTable: "PortfolioUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
