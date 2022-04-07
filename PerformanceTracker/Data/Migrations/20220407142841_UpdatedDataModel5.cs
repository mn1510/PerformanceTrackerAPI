using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformanceTrackerAPI.Data.Migrations
{
    public partial class UpdatedDataModel5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterLog_UserId",
                table: "ParameterLog",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterLog_Users_UserId",
                table: "ParameterLog",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterLog_Users_UserId",
                table: "ParameterLog");

            migrationBuilder.DropIndex(
                name: "IX_ParameterLog_UserId",
                table: "ParameterLog");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ParameterLog",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
