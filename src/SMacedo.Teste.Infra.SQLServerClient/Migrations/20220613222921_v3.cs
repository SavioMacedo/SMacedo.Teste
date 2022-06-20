using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMacedo.Teste.Infra.SQLServerClient.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                schema: "Leads",
                table: "SMacedoTeste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreateDate" },
                values: new object[] { "Painters", new DateTime(2022, 6, 13, 19, 29, 21, 104, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CreateDate" },
                values: new object[] { "Painters", new DateTime(2022, 6, 13, 19, 29, 21, 104, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreateDate" },
                values: new object[] { "Painters", new DateTime(2022, 6, 13, 19, 29, 21, 104, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "CreateDate" },
                values: new object[] { "Painters", new DateTime(2022, 6, 13, 19, 29, 21, 104, DateTimeKind.Local).AddTicks(4913) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                schema: "Leads",
                table: "SMacedoTeste");

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6602));
        }
    }
}
