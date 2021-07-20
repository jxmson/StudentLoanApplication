using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class Application : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "SAUniversities");

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Home = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionSAUniversityId = table.Column<int>(type: "int", nullable: true),
                    ProgrammeSACoursesId = table.Column<int>(type: "int", nullable: true),
                    StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfCompletion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HighSchool = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfSchoolCompletion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualificationObtained = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOnAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorCell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorHome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuarantorAddress3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorSuburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorCountry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_SACourses_ProgrammeSACoursesId",
                        column: x => x.ProgrammeSACoursesId,
                        principalTable: "SACourses",
                        principalColumn: "SACoursesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_SAUniversities_InstitutionSAUniversityId",
                        column: x => x.InstitutionSAUniversityId,
                        principalTable: "SAUniversities",
                        principalColumn: "SAUniversityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_InstitutionSAUniversityId",
                table: "Applications",
                column: "InstitutionSAUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProgrammeSACoursesId",
                table: "Applications",
                column: "ProgrammeSACoursesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "SAUniversities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/ufs.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/uct-Law-School-Logo.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/Wits.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/uj.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/images/cput.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/images/Tshwane.png");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 7,
                column: "ImageUrl",
                value: "~/images/rhodes.png");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 8,
                column: "ImageUrl",
                value: "~/images/nmmu.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 9,
                column: "ImageUrl",
                value: "~/images/Stellenbosch.jpeg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 10,
                column: "ImageUrl",
                value: "~/images/ukzn.png");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 11,
                column: "ImageUrl",
                value: "~/images/up.jpg");

            migrationBuilder.UpdateData(
                table: "SAUniversities",
                keyColumn: "SAUniversityId",
                keyValue: 12,
                column: "ImageUrl",
                value: "~/images/cut.jpg");
        }
    }
}
