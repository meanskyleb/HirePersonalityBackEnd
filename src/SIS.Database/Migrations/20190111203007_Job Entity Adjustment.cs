using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class JobEntityAdjustment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "JobTableAccess",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "JobHours",
                table: "JobTableAccess",
                newName: "Hours");

            migrationBuilder.RenameColumn(
                name: "JobDesiredPersonality",
                table: "JobTableAccess",
                newName: "DesiredPersonality");

            migrationBuilder.RenameColumn(
                name: "JobDesc",
                table: "JobTableAccess",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "JobCompensation",
                table: "JobTableAccess",
                newName: "Compensation");

            migrationBuilder.RenameColumn(
                name: "JobCompany",
                table: "JobTableAccess",
                newName: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "JobTableAccess",
                newName: "JobName");

            migrationBuilder.RenameColumn(
                name: "Hours",
                table: "JobTableAccess",
                newName: "JobHours");

            migrationBuilder.RenameColumn(
                name: "DesiredPersonality",
                table: "JobTableAccess",
                newName: "JobDesiredPersonality");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "JobTableAccess",
                newName: "JobDesc");

            migrationBuilder.RenameColumn(
                name: "Compensation",
                table: "JobTableAccess",
                newName: "JobCompensation");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "JobTableAccess",
                newName: "JobCompany");
        }
    }
}
