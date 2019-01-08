using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HirePersonality.Database.Migrations
{
    public partial class AddedJobandPersonalityentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTableAccess",
                columns: table => new
                {
                    JobEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTableAccess", x => x.JobEntityId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalityTableAccess",
                columns: table => new
                {
                    PersonalityEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalityTableAccess", x => x.PersonalityEntityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTableAccess");

            migrationBuilder.DropTable(
                name: "PersonalityTableAccess");
        }
    }
}
