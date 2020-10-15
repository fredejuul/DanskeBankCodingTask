using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanskeBankCodingTask.Migrations
{
    public partial class DanskeBankCodingTaskModelsMunicipalityTaxContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MunicipalityTaxes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Municipality = table.Column<string>(nullable: true),
                    TaxRate = table.Column<double>(nullable: false),
                    Schedule = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalityTaxes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "MunicipalityTaxes",
                columns: new[] { "ID", "EndDate", "Municipality", "Schedule", "StartDate", "TaxRate" },
                values: new object[,]
                {
                    { 1, new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Copenhagen", 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.20000000000000001 },
                    { 2, new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Copenhagen", 1, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.40000000000000002 },
                    { 3, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Copenhagen", 3, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.10000000000000001 },
                    { 4, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Copenhagen", 3, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.10000000000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MunicipalityTaxes");
        }
    }
}
