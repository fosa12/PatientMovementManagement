using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class seedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Patients",
                newName: "UserGuid");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Employees",
                newName: "UserGuid");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 19, 34, 228, DateTimeKind.Local).AddTicks(4281));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserGuid",
                table: "Patients",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserGuid",
                table: "Employees",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 15, 11, 147, DateTimeKind.Local).AddTicks(6715));
        }
    }
}
