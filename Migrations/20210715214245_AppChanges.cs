using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class AppChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MaritalStatus",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion2",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCompletion3",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofAdmission2",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofAdmission3",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Institution2SAUniversityId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Institution3SAUniversityId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Programme2SACoursesId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Programme3SACoursesId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentNumber2",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentNumber3",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Institution2SAUniversityId",
                table: "Applications",
                column: "Institution2SAUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Institution3SAUniversityId",
                table: "Applications",
                column: "Institution3SAUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Programme2SACoursesId",
                table: "Applications",
                column: "Programme2SACoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Programme3SACoursesId",
                table: "Applications",
                column: "Programme3SACoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SACourses_Programme2SACoursesId",
                table: "Applications",
                column: "Programme2SACoursesId",
                principalTable: "SACourses",
                principalColumn: "SACoursesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SACourses_Programme3SACoursesId",
                table: "Applications",
                column: "Programme3SACoursesId",
                principalTable: "SACourses",
                principalColumn: "SACoursesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SAUniversities_Institution2SAUniversityId",
                table: "Applications",
                column: "Institution2SAUniversityId",
                principalTable: "SAUniversities",
                principalColumn: "SAUniversityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SAUniversities_Institution3SAUniversityId",
                table: "Applications",
                column: "Institution3SAUniversityId",
                principalTable: "SAUniversities",
                principalColumn: "SAUniversityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SACourses_Programme2SACoursesId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SACourses_Programme3SACoursesId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SAUniversities_Institution2SAUniversityId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SAUniversities_Institution3SAUniversityId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_Institution2SAUniversityId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_Institution3SAUniversityId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_Programme2SACoursesId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_Programme3SACoursesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion2",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "DateOfCompletion3",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "DateofAdmission2",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "DateofAdmission3",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution2SAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution3SAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme2SACoursesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme3SACoursesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "StudentNumber2",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "StudentNumber3",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "Occupation",
                table: "Applications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatus",
                table: "Applications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Applications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
