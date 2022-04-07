using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformanceTrackerAPI.Data.Migrations
{
    public partial class UpdatedDataModel6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParameterId",
                table: "ParameterLog");

            migrationBuilder.DropColumn(
                name: "ParameterTypeId",
                table: "ParameterLog");

            migrationBuilder.AlterColumn<int>(
                name: "SubActivityId",
                table: "SubActivityParameter",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "SubActivity",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "SubActivityId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ParameterAllowedTypeId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterAllowedValueId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubActivityParameter_SubActivityId",
                table: "SubActivityParameter",
                column: "SubActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubActivity_ActivityId",
                table: "SubActivity",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterLog_ParameterAllowedTypeId",
                table: "ParameterLog",
                column: "ParameterAllowedTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterLog_ParameterAllowedValueId",
                table: "ParameterLog",
                column: "ParameterAllowedValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterLog_SubActivityId",
                table: "ParameterLog",
                column: "SubActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterLog_AllowedType_ParameterAllowedTypeId",
                table: "ParameterLog",
                column: "ParameterAllowedTypeId",
                principalTable: "AllowedType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterLog_AllowedValue_ParameterAllowedValueId",
                table: "ParameterLog",
                column: "ParameterAllowedValueId",
                principalTable: "AllowedValue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterLog_SubActivity_SubActivityId",
                table: "ParameterLog",
                column: "SubActivityId",
                principalTable: "SubActivity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubActivity_Activity_ActivityId",
                table: "SubActivity",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubActivityParameter_SubActivity_SubActivityId",
                table: "SubActivityParameter",
                column: "SubActivityId",
                principalTable: "SubActivity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterLog_AllowedType_ParameterAllowedTypeId",
                table: "ParameterLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ParameterLog_AllowedValue_ParameterAllowedValueId",
                table: "ParameterLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ParameterLog_SubActivity_SubActivityId",
                table: "ParameterLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SubActivity_Activity_ActivityId",
                table: "SubActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_SubActivityParameter_SubActivity_SubActivityId",
                table: "SubActivityParameter");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_SubActivityParameter_SubActivityId",
                table: "SubActivityParameter");

            migrationBuilder.DropIndex(
                name: "IX_SubActivity_ActivityId",
                table: "SubActivity");

            migrationBuilder.DropIndex(
                name: "IX_ParameterLog_ParameterAllowedTypeId",
                table: "ParameterLog");

            migrationBuilder.DropIndex(
                name: "IX_ParameterLog_ParameterAllowedValueId",
                table: "ParameterLog");

            migrationBuilder.DropIndex(
                name: "IX_ParameterLog_SubActivityId",
                table: "ParameterLog");

            migrationBuilder.DropColumn(
                name: "ParameterAllowedTypeId",
                table: "ParameterLog");

            migrationBuilder.DropColumn(
                name: "ParameterAllowedValueId",
                table: "ParameterLog");

            migrationBuilder.AlterColumn<int>(
                name: "SubActivityId",
                table: "SubActivityParameter",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "SubActivity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubActivityId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParameterTypeId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
