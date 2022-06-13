using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMacedo.Teste.Infra.SQLServerClient.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Leads",
                table: "SMacedoTeste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
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
                columns: new[] { "CreateDate", "Email", "Phone" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6591), "jerod_schaefer50@yahoo.com", "8226375275" });

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Email", "Phone" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6599), "zoila3@hotmail.com", "8226375275" });

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Email", "Phone" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6601), "annabel_moen@yahoo.com", "8226375275" });

            migrationBuilder.InsertData(
                schema: "Leads",
                table: "SMacedoTeste",
                columns: new[] { "Id", "CreateDate", "Description", "Email", "FirstName", "LastName", "LeadStatus", "Phone", "Price", "Suburb" },
                values: new object[] { 4, new DateTime(2022, 6, 13, 19, 1, 53, 787, DateTimeKind.Local).AddTicks(6602), "Plaster exposed brick walls (see photos), square off 2 archways (see photos), and expand pantry (see photos)", "stephany92@gmail.com", "Pete", "Parque", 1, "8226375275", 26.0, "Carramar 6031" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Leads",
                table: "SMacedoTeste");

            migrationBuilder.DropColumn(
                name: "Phone",
                schema: "Leads",
                table: "SMacedoTeste");

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                schema: "Leads",
                table: "SMacedoTeste",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 6, 13, 16, 17, 18, 388, DateTimeKind.Local).AddTicks(4616));
        }
    }
}
