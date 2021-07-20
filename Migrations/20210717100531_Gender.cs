using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Gender",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution2SAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution3SAUniversityId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme2SACoursesId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme3SACoursesId",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "Work",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Home",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Institution2Id",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Institution3Id",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstitutionId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OccupationId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Programme2Id",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Programme3Id",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgrammeId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritlStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { 1, "Female" },
                    { 2, "Male" },
                    { 3, "Prefer not to say" }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatus",
                columns: new[] { "MaritalStatusId", "MaritlStatusName" },
                values: new object[,]
                {
                    { 1, "Single" },
                    { 2, "Married" },
                    { 3, "Divorced" }
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "OccupationId", "OccupationName" },
                values: new object[,]
                {
                    { 1, "Student" },
                    { 2, "Unemployed" },
                    { 3, "Employed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_GenderId",
                table: "Applications",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_InstitutionId",
                table: "Applications",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_MaritalStatusId",
                table: "Applications",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OccupationId",
                table: "Applications",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProgrammeId",
                table: "Applications",
                column: "ProgrammeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Genders_GenderId",
                table: "Applications",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_MaritalStatus_MaritalStatusId",
                table: "Applications",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "MaritalStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Occupations_OccupationId",
                table: "Applications",
                column: "OccupationId",
                principalTable: "Occupations",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Genders_GenderId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_MaritalStatus_MaritalStatusId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Occupations_OccupationId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SACourses_ProgrammeId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_SAUniversities_InstitutionId",
                table: "Applications");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropIndex(
                name: "IX_Applications_GenderId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_InstitutionId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_MaritalStatusId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_OccupationId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ProgrammeId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution2Id",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Institution3Id",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OccupationId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme2Id",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Programme3Id",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ProgrammeId",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "Work",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Home",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Institution",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
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
    }
}
