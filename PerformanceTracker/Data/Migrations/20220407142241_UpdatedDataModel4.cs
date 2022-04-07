using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformanceTrackerAPI.Data.Migrations
{
    public partial class UpdatedDataModel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllowedType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParameterId = table.Column<int>(type: "INTEGER", nullable: false),
                    AllowedValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllowedValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParameterId = table.Column<int>(type: "INTEGER", nullable: false),
                    AllowedValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParameterLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LogEntryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubActivityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParameterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParameterTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    LogValue = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubActivityName = table.Column<string>(type: "TEXT", nullable: true),
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubActivityParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParameterName = table.Column<string>(type: "TEXT", nullable: true),
                    ParameterDescription = table.Column<string>(type: "TEXT", nullable: true),
                    SubActivityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubActivityParameter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedType");

            migrationBuilder.DropTable(
                name: "AllowedValue");

            migrationBuilder.DropTable(
                name: "ParameterLog");

            migrationBuilder.DropTable(
                name: "SubActivity");

            migrationBuilder.DropTable(
                name: "SubActivityParameter");
        }
    }
}
