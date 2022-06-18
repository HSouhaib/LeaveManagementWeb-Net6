using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "6b1738a9-c334-4899-bf58-02c025b9c239");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "56c58a3b-8058-4743-bdac-393d8a49e172");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2ca728f-ae91-49f9-a47d-a46dfafbc5aa", "AQAAAAEAACcQAAAAEPxMVAeMgDdKGXj3ij8xrkRvi5GWtXsBsxu2k4U+YE09AcB2ZFEcaqYa3t6kfxYR2w==", "d9c7e79f-1f45-480d-9a43-526ce6685426" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc01adfd-a002-4e46-92ce-d0c50c755cdf", "AQAAAAEAACcQAAAAECdFHgBp9/82a2Ip5qETsG0cfN3FN9EdbDXZ6J+9UlR/RtOK6wt9biNElac6O2PaqA==", "f6ea46de-abdc-48c2-9e9c-721afce6aede" });
        }
    }
}
