using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pars_UserValidation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    ClassRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ClassRoomId);
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
                        name: "FK_Lesson_Classroom_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "Classroom",
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
                name: "UserValidation",
                columns: table => new
                {
                    UserValidationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserValidation_Lesson_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserValidation_Teacher_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserValidation_Student_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentPresence = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserValidation", x => x.UserValidationId);
                    table.ForeignKey(
                        name: "FK_UserValidation_Lesson_UserValidation_Lesson_FK",
                        column: x => x.UserValidation_Lesson_FK,
                        principalTable: "Lesson",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserValidation_Student_UserValidation_Student_FK",
                        column: x => x.UserValidation_Student_FK,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserValidation_Teacher_UserValidation_Teacher_FK",
                        column: x => x.UserValidation_Teacher_FK,
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
                name: "IX_UserValidation_UserValidation_Lesson_FK",
                table: "UserValidation",
                column: "UserValidation_Lesson_FK");

            migrationBuilder.CreateIndex(
                name: "IX_UserValidation_UserValidation_Student_FK",
                table: "UserValidation",
                column: "UserValidation_Student_FK");

            migrationBuilder.CreateIndex(
                name: "IX_UserValidation_UserValidation_Teacher_FK",
                table: "UserValidation",
                column: "UserValidation_Teacher_FK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserValidation");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
