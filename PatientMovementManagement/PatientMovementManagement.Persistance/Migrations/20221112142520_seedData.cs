using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientMovementManagement.Persistance.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Position", "Specialization", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5311), "SYSTEM", null, null, null, null, "Lekarz", "Ortopeda", 1, new Guid("98fa81c6-6138-46c2-b8f3-48423d8ba2b8") },
                    { 2, new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5411), "SYSTEM", null, null, null, null, "Lekarz", "Chirurg ogólny", 1, new Guid("de29efab-23ff-4bed-a8db-63f35ca033e5") },
                    { 3, new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5424), "SYSTEM", null, null, null, null, "Lekarz", "Kardiolog", 1, new Guid("d10e1087-20e1-447b-8345-6e9611afd586") },
                    { 4, new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5434), "SYSTEM", null, null, null, null, "Lekarz", "Okulista", 1, new Guid("ce6b5893-e96b-4205-8782-76054a2e3784") },
                    { 5, new DateTime(2022, 11, 12, 15, 25, 20, 103, DateTimeKind.Local).AddTicks(5443), "SYSTEM", null, null, null, null, "Lekarz", "Onkolog", 1, new Guid("b6d34076-64cd-4939-9a6e-35fa89938241") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
