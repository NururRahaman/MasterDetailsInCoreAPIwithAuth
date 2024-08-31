using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam8_MasterDetailsInCoreAPIwithAuth.Migrations
{
    public partial class lema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderMasters",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 9, 1, 1, 1, 2, 249, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "OrderMasters",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 8, 31, 1, 1, 2, 251, DateTimeKind.Local).AddTicks(1400));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderMasters",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 9, 52, 22, 994, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "OrderMasters",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 6, 3, 9, 52, 22, 995, DateTimeKind.Local).AddTicks(5301));
        }
    }
}
