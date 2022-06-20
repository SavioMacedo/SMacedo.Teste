using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMacedo.Teste.Infra.SQLServerClient.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Leads");

            migrationBuilder.CreateTable(
                name: "SMacedoTeste",
                schema: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LeadStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMacedoTeste", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Leads",
                table: "SMacedoTeste",
                columns: new[] { "Id", "CreateDate", "Description", "FirstName", "LastName", "LeadStatus", "Price", "Suburb" },
                values: new object[] { 1, new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4606), "Need to paint 2 aluminum windows and a sliding glass door.", "Bill", "Clapton", 0, 62.0, "Yanderra 2574" });

            migrationBuilder.InsertData(
                schema: "Leads",
                table: "SMacedoTeste",
                columns: new[] { "Id", "CreateDate", "Description", "FirstName", "LastName", "LeadStatus", "Price", "Suburb" },
                values: new object[] { 2, new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4614), "internal walls 3 colors", "Craig", "List", 0, 49.0, "Woolooware 2230" });

            migrationBuilder.InsertData(
                schema: "Leads",
                table: "SMacedoTeste",
                columns: new[] { "Id", "CreateDate", "Description", "FirstName", "LastName", "LeadStatus", "Price", "Suburb" },
                values: new object[] { 3, new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4616), "another teste to make colors", "Savio", "Teste", 0, 600.5, "Nova Era 7890" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SMacedoTeste",
                schema: "Leads");
        }
    }
}
