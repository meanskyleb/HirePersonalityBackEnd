using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class CreateMethodFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobCompany",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobCompensation",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobDesc",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobDesiredPersonality",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobHours",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobName",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "JobTableAccess",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobCompany",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "JobCompensation",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "JobDesc",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "JobDesiredPersonality",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "JobHours",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "JobName",
                table: "JobTableAccess");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "JobTableAccess");
        }
    }
}
