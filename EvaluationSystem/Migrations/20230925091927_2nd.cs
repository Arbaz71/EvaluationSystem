using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Student_StudentId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_StudentId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Instructors");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Student",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "SendResignationRequest",
                table: "Instructor",
                newName: "IsResigned");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Surveys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseCode",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Results",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseCode",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "InstructorId");

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseCode = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseCode1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollment_Courses_CourseCode1",
                        column: x => x.CourseCode1,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(type: "float", nullable: false),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_InstructorId",
                table: "Surveys",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseCode",
                table: "Student",
                column: "CourseCode");

            migrationBuilder.CreateIndex(
                name: "IX_Results_InstructorId",
                table: "Results",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CourseCode",
                table: "Instructor",
                column: "CourseCode",
                unique: true,
                filter: "[CourseCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseCode1",
                table: "Enrollment",
                column: "CourseCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_InstructorId",
                table: "Evaluation",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Courses_CourseCode",
                table: "Instructor",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Instructor_InstructorId",
                table: "Results",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_CourseCode",
                table: "Student",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Instructor_InstructorId",
                table: "Surveys",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Courses_CourseCode",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Instructor_InstructorId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_CourseCode",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Instructor_InstructorId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_InstructorId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Student_CourseCode",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Results_InstructorId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_CourseCode",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Student",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Student",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IsResigned",
                table: "Instructors",
                newName: "SendResignationRequest");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Instructors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentId",
                table: "Results",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Student_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
