using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Recommendations",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NextVisitRecomended",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Diagnosis",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PESEL",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5898), "Jan", "Kowalski" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5962), "Andrzej", "Lesno" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5972), "Edward", "Abramczuk" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5981), "Ewa", "Kowalska" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(5990), "Janina", "Konieczna" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Created", "CreatedBy", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "PESEL", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6021), "SYSTEM", "Piotr", null, null, "Konieczny", null, null, "99050443415", 1, new Guid("6207233a-1fd5-4032-80c5-039bf7f62a13") },
                    { 2, new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6034), "SYSTEM", "Andrzej", null, null, "Wajda", null, null, "48080132121", 1, new Guid("4ce5d169-aeb9-44ca-864b-9e02959fce38") },
                    { 3, new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6195), "SYSTEM", "Jan", null, null, "Jagiełło", null, null, "92030332444", 1, new Guid("2728354a-70c3-4dbc-a7f9-078b27a6fd1e") },
                    { 4, new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6205), "SYSTEM", "Krystyna", null, null, "Kowalska", null, null, "05241477321", 1, new Guid("c41ebf5c-bb1e-4173-af49-13a2be331269") },
                    { 5, new DateTime(2022, 11, 12, 18, 3, 11, 857, DateTimeKind.Local).AddTicks(6215), "SYSTEM", "Michał", null, null, "Żabiński", null, null, "04300798759", 1, new Guid("0df563c6-7033-44a6-bb2f-c82706f02cb8") }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "Created", "CreatedBy", "Diagnosis", "EmployeeId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "NextVisitRecomended", "PatientId", "Recommendations", "StatusId", "VisitCode", "VisitDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 1, null, null, null, null, null, 1, null, 1, "TEST01", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 2, null, null, null, null, null, 1, null, 1, "TEST02", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 2, null, null, null, null, null, 1, null, 1, "TEST03", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 3, null, null, null, null, null, 1, null, 1, "TEST04", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 4, null, null, null, null, null, 1, null, 1, "TEST05", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", null, 5, null, null, null, null, null, 1, null, 1, "TEST06", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "Created", "CreatedBy", "Diagnosis", "EmployeeId", "Inactivated", "InactivatedBy", "IsVisitTookPlace", "Modified", "ModifiedBy", "NextVisitRecomended", "PatientId", "Recommendations", "StatusId", "VisitCode", "VisitDateTime" },
                values: new object[,]
                {
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 1, null, null, true, null, null, "Za tydzień", 1, null, 1, "TEST07", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 2, null, null, true, null, null, "Za tydzień", 1, null, 1, "TEST08", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 2, null, null, true, null, null, "Za tydzień", 1, null, 1, "TEST09", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 3, null, null, true, null, null, "Za tydzień", 1, null, 1, "TEST011", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 4, null, null, true, null, null, "Za trzy tygodnie", 1, null, 1, "TEST010", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SYSTEM", "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw", 5, null, null, true, null, null, "Za dwa tygodnie", 1, null, 1, "TEST12", new DateTime(2022, 11, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PESEL",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Recommendations",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NextVisitRecomended",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diagnosis",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5443));
        }
    }
}
