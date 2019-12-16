using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentPlanner.Migrations
{
    public partial class RestHymnOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RestHymnNumber",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RestHymnNumber",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
