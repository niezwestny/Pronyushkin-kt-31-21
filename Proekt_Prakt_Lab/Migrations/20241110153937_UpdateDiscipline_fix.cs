using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proekt_Prakt_Lab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiscipline_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_load_id",
                table: "cd_discipline");

            migrationBuilder.DropIndex(
                name: "idx_cd_discipline_fk_load_id",
                table: "cd_discipline");

            migrationBuilder.DropIndex(
                name: "IX_cd_discipline_discipline_load_id",
                table: "cd_discipline");

            migrationBuilder.DropColumn(
                name: "discipline_load_id",
                table: "cd_discipline");

            migrationBuilder.AddColumn<int>(
                name: "discipline_load_hours",
                table: "cd_discipline",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discipline_load_hours",
                table: "cd_discipline");

            migrationBuilder.AddColumn<int>(
                name: "discipline_load_id",
                table: "cd_discipline",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "idx_cd_discipline_fk_load_id",
                table: "cd_discipline",
                column: "discipline_load_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_discipline_discipline_load_id",
                table: "cd_discipline",
                column: "discipline_load_id",
                unique: true,
                filter: "[discipline_load_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "fk_load_id",
                table: "cd_discipline",
                column: "discipline_load_id",
                principalTable: "cd_load",
                principalColumn: "load_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
