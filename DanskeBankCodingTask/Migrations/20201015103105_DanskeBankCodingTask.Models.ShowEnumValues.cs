using Microsoft.EntityFrameworkCore.Migrations;

namespace DanskeBankCodingTask.Migrations
{
    public partial class DanskeBankCodingTaskModelsShowEnumValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Schedule",
                table: "MunicipalityTaxes",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Schedule",
                value: "Yearly");

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Schedule",
                value: "Monthly");

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 3,
                column: "Schedule",
                value: "Daily");

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 4,
                column: "Schedule",
                value: "Daily");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Schedule",
                table: "MunicipalityTaxes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Schedule",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Schedule",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 3,
                column: "Schedule",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MunicipalityTaxes",
                keyColumn: "ID",
                keyValue: 4,
                column: "Schedule",
                value: 3);
        }
    }
}
