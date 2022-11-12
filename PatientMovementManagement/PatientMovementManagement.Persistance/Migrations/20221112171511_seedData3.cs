using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class seedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDateTime",
                value: new DateTime(2022, 9, 11, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 10, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDateTime",
                value: new DateTime(2022, 10, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 4,
                column: "VisitDateTime",
                value: new DateTime(2022, 10, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 5,
                column: "VisitDateTime",
                value: new DateTime(2022, 10, 26, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 6,
                column: "VisitDateTime",
                value: new DateTime(2022, 10, 24, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 7,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 25, 11, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 8,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 17, 13, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 9,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 10,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 15, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 11,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 17, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 12,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 13, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 4,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 5,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 6,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 7,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 8,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 9,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 10,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 11,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 12,
                column: "VisitDateTime",
                value: new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
