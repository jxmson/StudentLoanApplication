using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class ChangedApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "InstitutionSAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ProgrammeSACoursesId",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "StudentNumber",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorWork",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorHome",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorAddress3",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Institution",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Programme",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Institution",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "StudentNumber",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorWork",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorHome",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GuarantorAddress3",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstitutionSAUniversityId",
                table: "Applications",
                type: "int",
                nullable: true);

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
    }
}
