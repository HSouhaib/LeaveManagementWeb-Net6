using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "e28d27af-cbe8-48d0-b743-4e5a9984d64c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "121e6592-3b2c-4d8b-abb2-e752910c5923");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc01adfd-a002-4e46-92ce-d0c50c755cdf", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECdFHgBp9/82a2Ip5qETsG0cfN3FN9EdbDXZ6J+9UlR/RtOK6wt9biNElac6O2PaqA==", "f6ea46de-abdc-48c2-9e9c-721afce6aede", "admin@localhot.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "c577ef47-67fe-4998-8e02-d9def892e242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "cc408b7c-36f1-4c9f-82e7-4d4634ff2b84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0fc04cb0-f4f9-477e-a1dc-f38a4e153279", false, null, "AQAAAAEAACcQAAAAEMRFYnbGxvqFGF+lmFoCn4gDivib3Q6WAOp2MzlygDe+hjLnjLC+8JLDQ+uK2u/zhA==", "120e38ec-6b53-47af-ba99-f6ddbe66a328", null });
        }
    }
}
