using Microsoft.EntityFrameworkCore.Migrations;

namespace HirePersonality.Database.Migrations
{
    public partial class Fixedotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DesiredPersonality",
                table: "JobTableAccess",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DesiredPersonality",
                table: "JobTableAccess",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
