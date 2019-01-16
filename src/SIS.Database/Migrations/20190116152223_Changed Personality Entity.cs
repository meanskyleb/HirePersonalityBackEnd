using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HirePersonality.Database.Migrations
{
    public partial class ChangedPersonalityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PersonalityTableAccess",
                nullable: false,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "PersonalityTableAccess",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
