using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class FixedApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "OccupationId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatusId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "GenderName",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatusName",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OccupationName",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Genders_GenderId",
                table: "Applications",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_MaritalStatus_MaritalStatusId",
                table: "Applications",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "MaritalStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Occupations_OccupationId",
                table: "Applications",
                column: "OccupationId",
                principalTable: "Occupations",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.DropColumn(
                name: "GenderName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "MaritalStatusName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OccupationName",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "OccupationId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatusId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
        }
    }
}
