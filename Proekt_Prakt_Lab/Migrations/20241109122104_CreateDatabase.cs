using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proekt_Prakt_Lab.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cd_degree",
                columns: table => new
                {
                    degree_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_degree_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_degree_degree_id", x => x.degree_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_load",
                columns: table => new
                {
                    load_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_load_load_id", x => x.load_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_position",
                columns: table => new
                {
                    position_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_position_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_position_position_id", x => x.position_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_discipline",
                columns: table => new
                {
                    discipline_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_discipline_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false),
                    discipline_load_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_discipline_discipline_id", x => x.discipline_id);
                    table.ForeignKey(
                        name: "fk_load_id",
                        column: x => x.discipline_load_id,
                        principalTable: "cd_load",
                        principalColumn: "load_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "cd_cafedra",
                columns: table => new
                {
                    cafedra_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_cafedra_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false),
                    main_teacher_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_cafedra_cafedra_id", x => x.cafedra_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_teacher",
                columns: table => new
                {
                    teacher_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_teacher_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false),
                    c_teacher_surname = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false),
                    c_teacher_second_name = table.Column<string>(type: "nvarchar(200)", maxLength: 100, nullable: false),
                    cafedra_id = table.Column<int>(type: "int", nullable: true),
                    position_id = table.Column<int>(type: "int", nullable: true),
                    degree_id = table.Column<int>(type: "int", nullable: true),
                    load_id = table.Column<int>(type: "int", nullable: true),
                    discipline_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_teacher_teacher_id", x => x.teacher_id);
                    table.ForeignKey(
                        name: "fk_cafedra_id",
                        column: x => x.cafedra_id,
                        principalTable: "cd_cafedra",
                        principalColumn: "cafedra_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_degree_id",
                        column: x => x.degree_id,
                        principalTable: "cd_degree",
                        principalColumn: "degree_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_discipline_id",
                        column: x => x.discipline_id,
                        principalTable: "cd_discipline",
                        principalColumn: "discipline_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_position_id",
                        column: x => x.position_id,
                        principalTable: "cd_position",
                        principalColumn: "position_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_teacher_load_id",
                        column: x => x.load_id,
                        principalTable: "cd_load",
                        principalColumn: "load_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "idx_cd_cafedra_fk_main_teacher_id",
                table: "cd_cafedra",
                column: "main_teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_cafedra_main_teacher_id",
                table: "cd_cafedra",
                column: "main_teacher_id",
                unique: true,
                filter: "[main_teacher_id] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "idx_cd_teacher_fk_cafedra_id",
                table: "cd_teacher",
                column: "cafedra_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_teacher_fk_degree_id",
                table: "cd_teacher",
                column: "degree_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_teacher_fk_discipline_id",
                table: "cd_teacher",
                column: "discipline_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_teacher_fk_load_id",
                table: "cd_teacher",
                column: "load_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_teacher_fk_position_id",
                table: "cd_teacher",
                column: "position_id");

            migrationBuilder.AddForeignKey(
                name: "fk_main_teacher_id",
                table: "cd_cafedra",
                column: "main_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_main_teacher_id",
                table: "cd_cafedra");

            migrationBuilder.DropTable(
                name: "cd_teacher");

            migrationBuilder.DropTable(
                name: "cd_cafedra");

            migrationBuilder.DropTable(
                name: "cd_degree");

            migrationBuilder.DropTable(
                name: "cd_discipline");

            migrationBuilder.DropTable(
                name: "cd_position");

            migrationBuilder.DropTable(
                name: "cd_load");
        }
    }
}
