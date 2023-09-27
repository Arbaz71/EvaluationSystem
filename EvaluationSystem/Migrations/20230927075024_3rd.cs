using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    /// <inheritdoc />
    public partial class _3rd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Courses_CourseCode1",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Instructor_InstructorId",
                table: "Evaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Courses_CourseCode",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Instructor_InstructorId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Instructor_InstructorId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "Enrollments");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_CourseCode",
                table: "Instructors",
                newName: "IX_Instructors_CourseCode");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseCode1",
                table: "Enrollments",
                newName: "IX_Enrollments_CourseCode1");

            migrationBuilder.AddColumn<string>(
                name: "InstructorName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SemesterName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "EnrollmentId");

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<int>(type: "int", nullable: false),
                    CourseCode1 = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => x.CourseStudentId);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseCode1",
                        column: x => x.CourseCode1,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentLeaveRequests",
                columns: table => new
                {
                    StudentLeaveRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLeaveRequests", x => x.StudentLeaveRequestId);
                    table.ForeignKey(
                        name: "FK_StudentLeaveRequests_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestions",
                columns: table => new
                {
                    SurveyQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestions", x => x.SurveyQuestionId);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "SurveyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyResponses",
                columns: table => new
                {
                    SurveyResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponses", x => x.SurveyResponseId);
                    table.ForeignKey(
                        name: "FK_SurveyResponses_SurveyQuestions_SurveyQuestionId",
                        column: x => x.SurveyQuestionId,
                        principalTable: "SurveyQuestions",
                        principalColumn: "SurveyQuestionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseCode1",
                table: "CourseStudents",
                column: "CourseCode1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLeaveRequests_StudentId",
                table: "StudentLeaveRequests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_SurveyId",
                table: "SurveyQuestions",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponses_SurveyQuestionId",
                table: "SurveyResponses",
                column: "SurveyQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseCode1",
                table: "Enrollments",
                column: "CourseCode1",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Student_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Instructors_InstructorId",
                table: "Evaluation",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseCode",
                table: "Instructors",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Instructors_InstructorId",
                table: "Results",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Instructors_InstructorId",
                table: "Surveys",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseCode1",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Student_StudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Instructors_InstructorId",
                table: "Evaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseCode",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Instructors_InstructorId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Instructors_InstructorId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "StudentLeaveRequests");

            migrationBuilder.DropTable(
                name: "SurveyResponses");

            migrationBuilder.DropTable(
                name: "SurveyQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "InstructorName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SemesterName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "Enrollments");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "Enrollment");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_CourseCode",
                table: "Instructor",
                newName: "IX_Instructor_CourseCode");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_CourseCode1",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseCode1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment",
                column: "EnrollmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Courses_CourseCode1",
                table: "Enrollment",
                column: "CourseCode1",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Instructor_InstructorId",
                table: "Evaluation",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Surveys_Instructor_InstructorId",
                table: "Surveys",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "InstructorId");
        }
    }
}
