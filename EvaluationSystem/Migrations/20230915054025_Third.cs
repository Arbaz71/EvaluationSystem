using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_DepartmentManagers_DepartmentManagerId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Users_AdminUserId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_AdminId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "DepartmentManagers");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_AdminUserId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentManagerId",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AdminId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdminUserId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentManagerId",
                table: "Instructors");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.AddColumn<int>(
                name: "userRole",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Student_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Student_StudentId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "userRole",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminUserId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentManagerId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.CreateTable(
                name: "DepartmentManagers",
                columns: table => new
                {
                    DepartmentManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentManagers", x => x.DepartmentManagerId);
                    table.ForeignKey(
                        name: "FK_DepartmentManagers_Users_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_AdminUserId",
                table: "Instructors",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentManagerId",
                table: "Instructors",
                column: "DepartmentManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdminId",
                table: "Students",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentManagers_AdminUserId",
                table: "DepartmentManagers",
                column: "AdminUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_DepartmentManagers_DepartmentManagerId",
                table: "Instructors",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManagers",
                principalColumn: "DepartmentManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Users_AdminUserId",
                table: "Instructors",
                column: "AdminUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_AdminId",
                table: "Students",
                column: "AdminId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
