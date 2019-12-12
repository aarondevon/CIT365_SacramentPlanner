using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentPlanner.Migrations
{
    public partial class FixDataInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
