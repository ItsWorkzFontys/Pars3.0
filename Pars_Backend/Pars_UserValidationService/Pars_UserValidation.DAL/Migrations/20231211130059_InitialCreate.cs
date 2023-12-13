using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pars_UserValidation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    ClassRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.ClassRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassRoom_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRoom",
                        principalColumn: "ClassRoomId");
                    table.ForeignKey(
                        name: "FK_Lesson_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "LessonId");
                });

            migrationBuilder.CreateTable(
                name: "ValidationDb",
                columns: table => new
                {
                    UserValidationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentPresence = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationDb", x => x.UserValidationId);
                    table.ForeignKey(
                        name: "FK_ValidationDb_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValidationDb_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValidationDb_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassRoomId",
                table: "Lesson",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_TeacherId",
                table: "Lesson",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LessonId",
                table: "Student",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationDb_LessonId",
                table: "ValidationDb",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationDb_StudentId",
                table: "ValidationDb",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationDb_TeacherId",
                table: "ValidationDb",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValidationDb");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "ClassRoom");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
