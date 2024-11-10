using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proekt_Prakt_Lab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiscipline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "c_discipline_teacher_id",
                table: "cd_discipline",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "idx_cd_discipline_fk_discipline_teacher_id",
                table: "cd_discipline",
                column: "c_discipline_teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_discipline_c_discipline_teacher_id",
                table: "cd_discipline",
                column: "c_discipline_teacher_id",
                unique: true,
                filter: "[c_discipline_teacher_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "fk_discipline_teacher_id",
                table: "cd_discipline",
                column: "c_discipline_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_discipline_teacher_id",
                table: "cd_discipline");

            migrationBuilder.DropIndex(
                name: "idx_cd_discipline_fk_discipline_teacher_id",
                table: "cd_discipline");

            migrationBuilder.DropIndex(
                name: "IX_cd_discipline_c_discipline_teacher_id",
                table: "cd_discipline");

            migrationBuilder.DropColumn(
                name: "c_discipline_teacher_id",
                table: "cd_discipline");
        }
    }
}
