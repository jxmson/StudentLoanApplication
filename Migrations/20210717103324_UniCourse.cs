using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class UniCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SACourses_ProgrammeId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SAUniversities_InstitutionId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_InstitutionId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ProgrammeId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ProgrammeId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "Programme3Id",
                table: "Applications",
                newName: "Name3");

            migrationBuilder.RenameColumn(
                name: "Programme2Id",
                table: "Applications",
                newName: "Name2");

            migrationBuilder.RenameColumn(
                name: "Institution3Id",
                table: "Applications",
                newName: "Course3");

            migrationBuilder.RenameColumn(
                name: "Institution2Id",
                table: "Applications",
                newName: "Course2");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InstitutionSAUniversityId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProgrammeSACoursesId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_InstitutionSAUniversityId",
                table: "Applications",
                column: "InstitutionSAUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProgrammeSACoursesId",
                table: "Applications",
                column: "ProgrammeSACoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SACourses_ProgrammeSACoursesId",
                table: "Applications",
                column: "ProgrammeSACoursesId",
                principalTable: "SACourses",
                principalColumn: "SACoursesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SAUniversities_InstitutionSAUniversityId",
                table: "Applications",
                column: "InstitutionSAUniversityId",
                principalTable: "SAUniversities",
                principalColumn: "SAUniversityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SACourses_ProgrammeSACoursesId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SAUniversities_InstitutionSAUniversityId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_InstitutionSAUniversityId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ProgrammeSACoursesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "InstitutionSAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ProgrammeSACoursesId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "Name3",
                table: "Applications",
                newName: "Programme3Id");

            migrationBuilder.RenameColumn(
                name: "Name2",
                table: "Applications",
                newName: "Programme2Id");

            migrationBuilder.RenameColumn(
                name: "Course3",
                table: "Applications",
                newName: "Institution3Id");

            migrationBuilder.RenameColumn(
                name: "Course2",
                table: "Applications",
                newName: "Institution2Id");

            migrationBuilder.AddColumn<int>(
                name: "InstitutionId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgrammeId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_InstitutionId",
                table: "Applications",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProgrammeId",
                table: "Applications",
                column: "ProgrammeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SACourses_ProgrammeId",
                table: "Applications",
                column: "ProgrammeId",
                principalTable: "SACourses",
                principalColumn: "SACoursesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_SAUniversities_InstitutionId",
                table: "Applications",
                column: "InstitutionId",
                principalTable: "SAUniversities",
                principalColumn: "SAUniversityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
