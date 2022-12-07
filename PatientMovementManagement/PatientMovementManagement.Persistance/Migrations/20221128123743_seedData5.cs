using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class seedData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 28, 13, 37, 43, 465, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.InsertData(
                table: "WorkPlans",
                columns: new[] { "Id", "Created", "CreatedBy", "EmployeeId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", 1, null, null, null, null, 1 });

            migrationBuilder.InsertData(
                table: "DaysInWorkPlan",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "WorkEnd", "WorkPlanId", "WorkStart" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, null, null, null, 1, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, null, null, null, 1, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, null, null, null, 1, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, null, null, null, 1, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, null, null, null, 1, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DaysInWorkPlan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DaysInWorkPlan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DaysInWorkPlan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DaysInWorkPlan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DaysInWorkPlan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkPlans",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
