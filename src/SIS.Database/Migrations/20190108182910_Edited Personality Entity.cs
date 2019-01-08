using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HirePersonality.Database.Migrations
{
    public partial class EditedPersonalityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalityNumber",
                table: "PersonalityTableAccess",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalityType",
                table: "PersonalityTableAccess",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "PersonalityTableAccess",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalityNumber",
                table: "PersonalityTableAccess");

            migrationBuilder.DropColumn(
                name: "PersonalityType",
                table: "PersonalityTableAccess");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonalityTableAccess");
        }
    }
}
