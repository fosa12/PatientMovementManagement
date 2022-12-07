using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class UpdateEntityAvailableVisits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayInWorkPlanId",
                table: "AvailableVisits",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 29, 11, 9, 34, 79, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.CreateIndex(
                name: "IX_AvailableVisits_DayInWorkPlanId",
                table: "AvailableVisits",
                column: "DayInWorkPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableVisits_DaysInWorkPlan_DayInWorkPlanId",
                table: "AvailableVisits",
                column: "DayInWorkPlanId",
                principalTable: "DaysInWorkPlan",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableVisits_DaysInWorkPlan_DayInWorkPlanId",
                table: "AvailableVisits");

            migrationBuilder.DropIndex(
                name: "IX_AvailableVisits_DayInWorkPlanId",
                table: "AvailableVisits");

            migrationBuilder.DropColumn(
                name: "DayInWorkPlanId",
                table: "AvailableVisits");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 28, 21, 39, 0, 171, DateTimeKind.Local).AddTicks(2713));
        }
    }
}
